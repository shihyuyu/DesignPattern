using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleFactoryPattern.Helper
{
	/// <summary>
	/// 這是一個簡單工廠模式的類別
	/// </summary>
	public class SimpleFactoryHelper
	{
		/// <summary>
		/// 產品類型
		/// </summary>
		public enum ProductType
		{
			None,
			Box,
			Food,
			Toy
		}
		/// <summary>
		/// 這是一個取得產品的機器，輸入想要製作的產品，它就會回傳產品給你
		/// </summary>
		/// <param name="t"></param>
		/// <returns></returns>
		public string GetProduct(ProductType t)
		{
			string ret = "";

			switch (t)
			{
				case ProductType.Box:		// 箱子
					ret = getBox();
					break;
				case ProductType.Food:	// 食物
					ret = getFood();
					break;
				case ProductType.Toy:		// 玩具
					ret = getToy();
					break;
				case ProductType.None:	// 其他
				default:
					ret = "";
					break;
			} // switch()

			return ret;
		} // public string GetProduct()
		/// <summary>
		/// 製作箱子
		/// </summary>
		/// <returns></returns>
		private string getBox() 
		{
			// 這裡放的是箱子的製作方法，你想怎麼做都可以..
			string ret = "~/Img/box.jpg";
			return ret;
		} // private string getBox()
		/// <summary>
		/// 製作食物
		/// </summary>
		/// <returns></returns>
		private string getFood()
		{
			// 這裡放的是食物的製作方法，你想怎麼做都可以..
			string ret = "~/Img/food.jpg";
			return ret;
		} // private string getFood()
		/// <summary>
		/// 製作玩具
		/// </summary>
		/// <returns></returns>
		private string getToy()
		{
			// 這裡放的是玩具的製作方法，你想怎麼做都可以..
			string ret = "~/Img/toy.jpg";
			return ret;
		} // private string getToy()
	}
}