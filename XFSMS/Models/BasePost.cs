﻿using System;
using PropertyChanged;

namespace XFSMS.Models
{
    [AddINotifyPropertyChangedInterface]
    public class BasePost
    {

        public string ImageUri { get; set; }

        public string ID { get; set; }

        public string Heading { get; set; }

        public string Description { get; set; }

        public DateTime PostStartDate { get; set; }

        public DateTime PostEndDate { get; set; }

        public BasePost()
        {
            ID = Guid.NewGuid().ToString();
            Heading = "Heading";
            Description = "Description";
            PostStartDate = DateTime.Today;
            PostEndDate = DateTime.Today.AddDays(5);


        }

    }
}
