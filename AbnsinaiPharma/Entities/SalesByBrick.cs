using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbnsinaiPharma.Entities
{
	public class SalesByBrick
	{

		public Int64 Id { get; set; }
		public string SupplierCode { get; set; }
		public string SupplierName { get; set; }  // realation Supppid

		public string ItemCode { get; set; }
		public string ItemName { get; set; }  // realation  Itemid
		public string Brick { get; set; }
		public string BrickName { get; set; }  // realation Brickid

		public Int64  TotalQuantity  { get; set; }
	}
}
