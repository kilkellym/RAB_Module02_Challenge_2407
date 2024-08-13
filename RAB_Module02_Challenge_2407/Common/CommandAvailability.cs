﻿namespace RAB_Module02_Challenge_2407.Common
{
	internal class CommandAvailability : IExternalCommandAvailability
	{
		public bool IsCommandAvailable(UIApplication applicationData, CategorySet selectedCategories)
		{
			bool result = false;
			UIDocument activeDoc = applicationData.ActiveUIDocument;
			if (activeDoc != null && activeDoc.Document != null)
			{
				result = true;
			}

			return result;
		}
	}
}
