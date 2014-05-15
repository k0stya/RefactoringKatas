using System.Collections.Generic;

namespace Refactoring.SroutMethod
{
	public class TransactionGate
	{
		private readonly TransactionBundle _transactionBundle;

		public TransactionGate(TransactionBundle transactionBundle)
		{
			_transactionBundle = transactionBundle;
		}

		public void PostEntries(List<Entry> entries)
		{
			foreach (var entry in entries)
			{
				entry.PostDate();
			}
			_transactionBundle.GetListManager().AddRange(entries);
		}
		// ...
	}
}
