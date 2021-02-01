using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AbnsinaiPharma.Entities
{
	public class SalesAndStock
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

		public string StockCode { get; set; }  // realation StockId
		public Int64 StockValue { get; set; }
		public Int64 SalesQty { get; set; }
		public Int64 FU { get; set; }

		public Int64 SalesValue { get; set; }
		public Int64 TotalSales { get; set; }




	}
}
