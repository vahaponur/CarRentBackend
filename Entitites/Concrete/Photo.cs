using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entitites.Concrete
{
    public class Photo : IEntity
    {
        DateTime _date;
        public int Id { get; set; }
        public int CarId { get; set; }
        public string ImagePath { get; set; }
        public DateTime Date
        {
            get; set;
        }
    }
}
