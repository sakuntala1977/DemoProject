﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityProject.Models
{
	class Product
	{
		
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		[Column(TypeName ="decimal(18,2)")]
		public int Price { get; set; }
	}
}
