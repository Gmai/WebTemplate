using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace GYM.Infrastructure.CrossCutting.Utils
{
  public class ObjectUtils
  {
    public static void CheckNullObj(object obj)
    {
      PropertyInfo[] fields = obj.GetType().GetProperties();
      foreach (var _f in fields)
      {
        if (_f.GetValue(obj, null) == null)
        {
          if (_f.PropertyType == typeof(DateTime))
          {
            try
            {
              DateTime dt = Convert.ToDateTime(_f.GetValue(obj, null));
              if (dt < Definitions.MinDate) _f.SetValue(obj, Definitions.MinDate);
            }
            catch
            {
              _f.SetValue(obj, Definitions.MinDate);
            }
          }
          else if (_f.PropertyType == typeof(int))
          {
            _f.SetValue(obj, -1);
          }
          else if (_f.PropertyType == typeof(Int16))
          {
            _f.SetValue(obj, -1);
          }
          else if (_f.PropertyType == typeof(Int64))
          {
            _f.SetValue(obj, -1);
          }
          else if (_f.PropertyType == typeof(Nullable<Int64>))
          {
            _f.SetValue(obj, -1);
          }
          else if (_f.PropertyType == typeof(Nullable<short>))
          {
            _f.SetValue(obj, (short)-1);
          }
          else if (_f.PropertyType == typeof(Nullable<byte>))
          {
            _f.SetValue(obj, (byte)0);
          }
          else if (_f.PropertyType == typeof(String))
          {
            _f.SetValue(obj, "");
          }
        }
        else
        {
          if (_f.PropertyType == typeof(DateTime))
          {
            try
            {
              DateTime dt = Convert.ToDateTime(_f.GetValue(obj, null));
              if (dt < Definitions.MinDate) _f.SetValue(obj, Definitions.MinDate);
            }
            catch
            {
              _f.SetValue(obj, Definitions.MinDate);
            }
          }
        }
      }
    }
  }
}
