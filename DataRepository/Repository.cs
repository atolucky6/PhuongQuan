using ATSCADA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataRepository
{
    public partial class Repository : Component
    {
        private readonly Dictionary<string, ITag> _tagCollection = new Dictionary<string, ITag>();

        private iDriver _driver;

        [Description("Select Driver for DataRepository")]
        [Browsable(true), Category("ATSCADA Settings")]
        public iDriver Driver
        {
            get { return _driver; }
            set
            {
                if (_driver != null) _driver.ConstructionCompleted -= Driver_ConstructionCompleted;
                _driver = value;
                if (_driver != null) _driver.ConstructionCompleted += Driver_ConstructionCompleted;
            }
        }        

        public event Action ConstructionCompleted;        

        public Repository()
        {
            InitializeComponent();
        }

        public Repository(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        public ITag this[string tagName]
        {
            get
            {
                if (string.IsNullOrEmpty(tagName)) return null;

                _tagCollection.TryGetValue(tagName, out ITag tag);
                return tag;
            }
        }

        private void Driver_ConstructionCompleted()
        {
            foreach (var task in _driver.TaskCollection)
            {
                foreach (var tag in task.TagCollection)
                {
                    _tagCollection.Add(
                        string.Format("{0}.{1}", task.Name, tag.Name),
                        tag);
                }
            }

            ConstructionCompleted?.Invoke();
        }
    }
}
