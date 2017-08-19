using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewComponents.Models
{
    public class SearchBarViewModel
    {
        public List<SearchBarItemViewModel> Items { get; }
        public string HeaderText { get; }
        public string ControllerName { get; }
        public string ActionName { get; }
        public string FormMethod { get; }

        public SearchBarViewModel (List<SearchBarItemViewModel> items, string controllerName, string actionName, string formMethod, string headerText = "")
        {
            Items = items;
            HeaderText = headerText;
        }
    }
}
