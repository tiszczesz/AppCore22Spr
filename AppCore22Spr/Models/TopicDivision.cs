namespace AppCore22Spr.Models {
    public class TopicDivision {
        public int DivisionID { get; set; }
        public Division Division { get; set; }
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
    }
}