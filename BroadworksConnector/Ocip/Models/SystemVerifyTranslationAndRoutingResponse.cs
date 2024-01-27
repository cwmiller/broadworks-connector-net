using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Represents a Verify Translation and Routing Test Call Result.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:19356""}]")]
    public class SystemVerifyTranslationAndRoutingResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _result;

        [XmlElement(ElementName = "Result", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:19356")]
        public string Result
        {
            get => _result;
            set
            {
                ResultSpecified = true;
                _result = value;
            }
        }

        [XmlIgnore]
        protected bool ResultSpecified { get; set; }

    }
}
