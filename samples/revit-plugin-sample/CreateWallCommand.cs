using System;
using System.Linq;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;

namespace CoraAgentShowcase.Sample
{
    [Transaction(TransactionMode.Manual)]
    public class CreateWallCommand : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            UIDocument uidoc = commandData.Application.ActiveUIDocument;
            Document doc = uidoc.Document;

            Level level = new FilteredElementCollector(doc)
                .OfClass(typeof(Level))
                .Cast<Level>()
                .OrderBy(l => l.Elevation)
                .FirstOrDefault();

            if (level == null)
            {
                message = "No level found in current document.";
                return Result.Failed;
            }

            WallType wallType = new FilteredElementCollector(doc)
                .OfClass(typeof(WallType))
                .Cast<WallType>()
                .FirstOrDefault();

            if (wallType == null)
            {
                message = "No wall type found in current document.";
                return Result.Failed;
            }

            XYZ p0 = new XYZ(0, 0, 0);
            XYZ p1 = new XYZ(20, 0, 0); // sample length in internal units (feet)
            Line baseline = Line.CreateBound(p0, p1);

            using (Transaction tx = new Transaction(doc, "Create wall sample"))
            {
                tx.Start();
                double height = 10.0;
                double offset = 0.0;
                bool flip = false;
                bool structural = false;

                Wall.Create(doc, baseline, wallType.Id, level.Id, height, offset, flip, structural);
                tx.Commit();
            }

            return Result.Succeeded;
        }
    }
}
