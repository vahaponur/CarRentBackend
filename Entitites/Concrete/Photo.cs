using Core.Entities;
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
            get { return _date; }
            set
            {
                _date = DateTime.Now;
            }
                }
    }
}
