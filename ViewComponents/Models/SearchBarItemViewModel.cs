using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewComponents.Models.Enums;

namespace ViewComponents.Models
{
    public class SearchBarItemViewModel
    {
        public string Id { get; }
        public InputTypes InputType { get; }
        public string LabelText { get; }
        public string PlaceHolderText { get; }
        public string Text { get; }

        public SearchBarItemViewModel(string id, InputTypes inputType, string labelText = "", string placeHolderText = "", string text = "")
        {
            Id = id;
            InputType = inputType;
            LabelText = labelText;
            PlaceHolderText = placeHolderText;
            Text = text;
        }
    }
}
