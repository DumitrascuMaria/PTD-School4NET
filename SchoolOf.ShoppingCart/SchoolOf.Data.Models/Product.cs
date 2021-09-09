using SchoolOf.Data.Abstraction;
using System;

namespace SchoolOf.Data.Models
{
    public class Product : BaseEntityModel
    {
       
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

        public string Category { get; set; }
        public string Image { get; set; }
        public long Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsDeleted { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTimeOffset CreatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTimeOffset ModifiedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        //toate modelele vor avea met de mai jos +long id

    }
}
