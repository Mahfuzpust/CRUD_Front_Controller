using System.Diagnostics.Metrics;

namespace CRUD_Front_Controller.Models.Cascade
{
    public class State
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }
    }
}
