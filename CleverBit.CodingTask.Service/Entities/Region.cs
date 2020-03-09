namespace CleverBit.CodingTask.Domain.Entities
{
    public class Region
    {
        public int RegionId { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }

        public bool IsParent()
        {                        
            return ParentId == 0 ? true : false;
        }       
    }
}
