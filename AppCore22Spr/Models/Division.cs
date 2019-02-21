using System.Collections;
using System.Collections.Generic;

namespace AppCore22Spr.Models {
    public class Division {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IList<TopicDivision> TopicDivisionList { get; set; }
        public SchoolType SchoolType { get; set; }
    }
}