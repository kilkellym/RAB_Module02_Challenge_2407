
namespace RAB_Module02_Challenge_2407.Common
{
	internal static class Utils
	{
		public static PipeType GetPipeTypeByName(Document doc, string value)
		{
			FilteredElementCollector collector = new FilteredElementCollector(doc);
			collector.OfClass(typeof(PipeType));

			foreach (PipeType type in collector)
			{
				if (type.Name == value)
					return type;
			}

			return null;
		}

		public static DuctType GetDuctTypeByName(Document doc, string value)
		{
			FilteredElementCollector collector = new FilteredElementCollector(doc);
			collector.OfClass(typeof(DuctType));

			foreach (DuctType type in collector)
			{
				if (type.Name == value)
					return type;
			}

			return null;
		}

		public static MEPSystemType GetMEPSystemTypeByName(Document doc, string value)
		{
			FilteredElementCollector collector = new FilteredElementCollector(doc);
			collector.OfClass(typeof(MEPSystemType));

			foreach (MEPSystemType type in collector)
			{
				if (type.Name == value)
					return type;
			}

			return null;
		}

		public static WallType GetWallTypeByName(Document doc, string value)
		{
			FilteredElementCollector collector = new FilteredElementCollector(doc);
			collector.OfClass(typeof(WallType));

			foreach (WallType type in collector)
			{
				if (type.Name == value)
					return type;
			}

			return null;
		}

		public static Level GetLevelByName(Document doc, string value)
		{
			FilteredElementCollector collector = new FilteredElementCollector(doc);
			collector.OfClass(typeof(Level));

			foreach (Level level in collector)
			{
				if (level.Name == value)
					return level;
			}

			return null;
		}
		internal static RibbonPanel? CreateRibbonPanel(UIControlledApplication app, string tabName, string panelName)
		{
			RibbonPanel? curPanel;

			if (GetRibbonPanelByName(app, tabName, panelName) == null)
				curPanel = app.CreateRibbonPanel(tabName, panelName);

			else
				curPanel = GetRibbonPanelByName(app, tabName, panelName);

			return curPanel;
		}

		internal static RibbonPanel? GetRibbonPanelByName(UIControlledApplication app, string tabName, string panelName)
		{
			foreach (RibbonPanel tmpPanel in app.GetRibbonPanels(tabName))
			{
				if (tmpPanel.Name == panelName)
					return tmpPanel;
			}

			return null;
		}
	}
}
