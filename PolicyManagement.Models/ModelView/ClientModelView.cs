﻿
using PolicyManagement.Models.ModelView;

namespace PolicyManagement.Models.ModelView
{
    public class ClientModelView: BaseModelView
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public string Direction { get; set; }
    }
}
