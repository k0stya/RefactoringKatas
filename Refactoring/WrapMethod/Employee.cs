using System;
using System.Collections.Generic;

namespace Refactoring.WrapMethod
{
	public class Employee
	{
		private List<DateTime> _payPeriod = new List<DateTime>();
		private DateTime _date;
		private DateTime[] _timecards;
		private PayDispatcher payDispatcher;
		private decimal _payRate;

		public void Pay()
		{
			Money amount = new Money();
			foreach (var timecard in _timecards)
			{
				if (_payPeriod.Contains(_date))
				{
					amount.Add(timecard.Hour * _payRate);
				}
			}
			payDispatcher.Pay(this, _date, amount);
		}
	}
}