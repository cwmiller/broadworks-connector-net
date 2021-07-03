using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemFileRepositoryDeviceUserGetRequest.
    /// <see cref="SystemFileRepositoryDeviceUserGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:10466""}]")]
    public class SystemFileRepositoryDeviceUserGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _allowPut;

        [XmlElement(ElementName = "allowPut", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10466")]
        public bool AllowPut
        {
            get => _allowPut;
            set
            {
                AllowPutSpecified = true;
                _allowPut = value;
            }
        }

        [XmlIgnore]
        protected bool AllowPutSpecified { get; set; }

        private bool _allowDelete;

        [XmlElement(ElementName = "allowDelete", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10466")]
        public bool AllowDelete
        {
            get => _allowDelete;
            set
            {
                AllowDeleteSpecified = true;
                _allowDelete = value;
            }
        }

        [XmlIgnore]
        protected bool AllowDeleteSpecified { get; set; }

        private bool _allowGet;

        [XmlElement(ElementName = "allowGet", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:10466")]
        public bool AllowGet
        {
            get => _allowGet;
            set
            {
                AllowGetSpecified = true;
                _allowGet = value;
            }
        }

        [XmlIgnore]
        protected bool AllowGetSpecified { get; set; }

    }
}
