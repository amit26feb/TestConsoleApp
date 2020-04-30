using System.Collections.Generic;

namespace TestingApp
{
    class SortClass : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return DoCompare(x, y);
        }

        protected int DoCompare(Student x, Student y)
        {

            string xvalue = x.Comments;
            string yvalue = y.Comments;



            int compareresult = 0;
            //if (_SortDataType == BLSortDataType.Number)
            //{
            //    if (xvalue.Contains("."))
            //    {
            //        if (Decimal.TryParse(xvalue, out decimal xvalu))
            //        {
            //            xvalu = Math.Round(xvalu, 0);
            //            xvalue = xvalu.ToString();
            //        }
            //    }

            //    if (yvalue.Contains("."))
            //    {
            //        if (Decimal.TryParse(yvalue, out decimal yvalu))
            //        {
            //            yvalu = Math.Round(yvalu, 0);
            //            yvalue = yvalu.ToString();
            //        }
            //    }

            //    if (!Int64.TryParse(xvalue, out long xval))
            //    {
            //        if (string.IsNullOrWhiteSpace(xvalue))
            //        {
            //            xval = -1;
            //        }
            //        else
            //        {
            //            xval = 0;
            //        }
            //    }

            //    if (!Int64.TryParse(yvalue, out long yval))
            //    {
            //        if (string.IsNullOrWhiteSpace(yvalue))
            //        {
            //            yval = -1;
            //        }
            //        else
            //        {
            //            yval = 0;
            //        }
            //    }

            //    if (xval > yval)
            //    {
            //        compareresult = 1;
            //    }
            //    else if (xval < yval)
            //    {
            //        compareresult = -1;
            //    }
            //    else
            //    {
            //        compareresult = 0;
            //    }
            //}
            //else if (_SortDataType == BLSortDataType.Decimal)
            //{
            //    if (!Decimal.TryParse(xvalue, out decimal xval))
            //    {
            //        if (string.IsNullOrWhiteSpace(xvalue))
            //        {
            //            xval = -1;
            //        }
            //        else
            //        {
            //            xval = 0;
            //        }
            //    }

            //    if (!Decimal.TryParse(yvalue, out decimal yval))
            //    {
            //        if (string.IsNullOrWhiteSpace(yvalue))
            //        {
            //            yval = -1;
            //        }
            //        else
            //        {
            //            yval = 0;
            //        }
            //    }

            //    if (xval > yval)
            //    {
            //        compareresult = 1;
            //    }
            //    else if (xval < yval)
            //    {
            //        compareresult = -1;
            //    }
            //    else
            //    {
            //        compareresult = 0;
            //    }
            //}
            //else if (_SortDataType == BLSortDataType.Timestamp || _SortDataType == BLSortDataType.Date || _SortDataType == BLSortDataType.Time)
            //{
            //    string format = sortfield.GetBLDataRowComparerSortFieldFormat(); //preferentially get format from sort field object.
            //    if (string.IsNullOrWhiteSpace(format)) //if necessary, fallback to comparer object format.
            //    {
            //        if (_SortDataType == BLSortDataType.Date)
            //        {
            //            format = DateFormat;
            //        }
            //        else if (_SortDataType == BLSortDataType.Time)
            //        {
            //            format = TimeFormat;
            //        }
            //        else
            //        {
            //            format = DateTimeFormat;
            //        }
            //    }

            //    DateTime xval = new DateTime(1900, 1, 1, 0, 0, 0);
            //    if (!DateTime.TryParseExact(xvalue, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out xval))
            //    {
            //        if (string.IsNullOrWhiteSpace(xvalue))
            //        {
            //            xval = new DateTime(1900, 1, 1, 0, 0, 0).AddDays(-1);
            //        }
            //        else
            //        {
            //            xval = new DateTime(1900, 1, 1, 0, 0, 0);
            //        }
            //    }

            //    DateTime yval = new DateTime(1900, 1, 1, 0, 0, 0);
            //    if (!DateTime.TryParseExact(yvalue, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out yval))
            //    {
            //        if (string.IsNullOrWhiteSpace(yvalue))
            //        {
            //            yval = new DateTime(1900, 1, 1, 0, 0, 0).AddDays(-1);
            //        }
            //        else
            //        {
            //            yval = new DateTime(1900, 1, 1, 0, 0, 0);
            //        }
            //    }

            //    if (xval > yval)
            //    {
            //        compareresult = 1;
            //    }
            //    else if (xval < yval)
            //    {
            //        compareresult = -1;
            //    }
            //    else
            //    {
            //        compareresult = 0;
            //    }
            //}
            //else
            //{
            compareresult = string.Compare(xvalue, yvalue);
            //}

            //if (_SortOrder == ListSortDirection.Ascending) //ascending sort
            //{
            //    if (compareresult > 0)
            //    {
            //        return 1;
            //    }
            //    else if (compareresult < 0)
            //    {
            //        return -1;
            //    }
            //}
            //else //descending sort
            //{
            if (compareresult > 0)
            {
                return -1;
            }
            else if (compareresult < 0)
            {
                return 1;
            }
            // }
            //}

            return 0;
        }
    }
}
