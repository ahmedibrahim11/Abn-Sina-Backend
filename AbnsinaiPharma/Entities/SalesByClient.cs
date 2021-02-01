using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbnsinaiPharma.Entities
{
	public class SalesByClient
	{
		public Int64 Id { get; set; }
		public DateTime Date { get; set; }
		public string Code { get; set; }
		public string BranchCode { get; set; }
		public string BranchName { get; set; }  // realation Branchid
		public string SupplierCode { get; set; }
		public string SupplierName { get; set; }  // realation Supppid

		public string ItemCode { get; set; }
		public string ItemName { get; set; }  // realation  Itemid

		public string BrickCode { get; set; }
		public string BrickName { get; set; }  // realation Brickid
		public string  Governorate  { get; set; }  // realation Gov
		public string  City  { get; set; }  // realation City

		public string MainCustomerCode  { get; set; }
		public string  ClientCode  { get; set; }
		public string   ClientName   { get; set; }
		public string Segment { get; set; }
		public string  ClientAddress_AR { get; set; }
		public string ClientAddress_Eng { get; set; }

		public Int64   Quantity  { get; set; }
		public Int64 Value  { get; set; }

		public Int64 ToTalQuantity { get; set; }



	}
}
