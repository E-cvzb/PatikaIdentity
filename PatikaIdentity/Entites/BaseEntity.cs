namespace PatikaIdentity.Entites
{
    public class BaseEntity
    {

        public BaseEntity()
        {
            CreateTime = DateTime.Now;
        }

        public int Id { get; set; }
        public DateTime CreateTime { get; set; }
        public bool IsDelete { get; set; }

    }
}
