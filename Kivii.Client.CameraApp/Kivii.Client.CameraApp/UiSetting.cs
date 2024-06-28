using Kivii.Configuration;
using Kivii.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kivii.Client.Finances.Icbc
{
    [Alias(Configs.TableUiSetting)]
    internal class UiSetting : Entity
    {
        [Required]
        [Unique("Form-Control")]
        public string FormName { get; set; }
        [Required]
        [Unique("Form-Control")]
        public string ControlName { get; set; }
        [Default("")]
        public string ControlValue { get; set; }
    }
}
