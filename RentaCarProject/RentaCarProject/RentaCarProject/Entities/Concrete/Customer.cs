using System;
using System.ComponentModel.DataAnnotations;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Entities.Concrete
{
    public class Customer:IEntity
	{

        public int Id { get; set; }
        public int UserId { get; set; }
		public string? CompanyName { get; set; }
       
    }
}

