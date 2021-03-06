﻿using System.ComponentModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using QuantBox.Design;
using QuantBox.XApi;

namespace QuantBox
{
    [DefaultProperty("Label")]
    [TypeConverter(typeof(UserInfoConverter))]
    [JsonConverter(typeof(NoTypeConverterJsonConverter<UserInfo>))]
    [DataContract]
    public class UserInfo
    {
        [Category("标签")]
        [DataMember]
        public string Label { get; set; }
        [Category("账号")]
        [DataMember]
        public string UserId { get; set; }
        [Category("账号")]
        [DataMember]
        public string Password { get; set; }
        [Category("账号")]
        [DataMember]
        public string FundId { get; set; }
        [Category("账号")]
        [DataMember]
        public string CombiId { get; set; }
        [Category("账号")]
        [DataMember]
        public string StockHolderId { get; set; }

        public UserInfoField Get()
        {
            var field = new UserInfoField {
                UserID = UserId,
                Password = Password
            };
            return field;
        }

        public override string ToString()
        {
            return string.IsNullOrEmpty(Label) ? "空用户" : Label;
        }

        public UserInfo Clone()
        {
            return (UserInfo)MemberwiseClone();
        }
    }
}
