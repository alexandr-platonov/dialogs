using System.Collections.Generic;

namespace Dialogs.Models.Alisa
{
    public class HookahMixViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<TobaccoMixViewModel> Tobaccos { get; set; }
    }
}