using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace MVCHomework.Models
{
    public class 自訂手機號碼Attribute: DataTypeAttribute
    {
        public 自訂手機號碼Attribute() : base(DataType.Text)
        {
            this.ErrorMessage = "ERROR 格式為0911-123456";
        }
        public override bool IsValid(object value)
        {
            Regex regex = new Regex(@"\d{4}-\d{6}");

            return regex.IsMatch(value.ToString());
        }
    }
}