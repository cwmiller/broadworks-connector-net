using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemLicensingGetRequest21sp1. The subscriber license table columns are: "Name", "Licensed", "Used" and "Available".
    /// The group service license table columns are: "Name", "Licensed", "Used" and "Available".
    /// The virtual service license table columns are: "Name", "Licensed", "Used" and "Available".
    /// The user service license table columns are: "Name", "Licensed", "Used", "Available", "Used By Hosted Users", "Used By Trunk Users", and "Expiration Date".
    /// The system param license table columns are: "Name", "Licensed", "Used", Available".
    /// <see cref="SystemLicensingGetRequest21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:11634""}]")]
    public class SystemLicensingGetResponse21sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.LicenseStrictness _licenseStrictness;

        [XmlElement(ElementName = "licenseStrictness", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:11634")]
        public BroadWorksConnector.Ocip.Models.LicenseStrictness LicenseStrictness
        {
            get => _licenseStrictness;
            set
            {
                LicenseStrictnessSpecified = true;
                _licenseStrictness = value;
            }
        }

        [XmlIgnore]
        protected bool LicenseStrictnessSpecified { get; set; }

        protected int _groupUserlimit;

        [XmlElement(ElementName = "groupUserlimit", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:11634")]
        [MinInclusive(1)]
        public int GroupUserlimit
        {
            get => _groupUserlimit;
            set
            {
                GroupUserlimitSpecified = true;
                _groupUserlimit = value;
            }
        }

        [XmlIgnore]
        protected bool GroupUserlimitSpecified { get; set; }

        protected string _expirationDate;

        [XmlElement(ElementName = "expirationDate", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:11634")]
        public string ExpirationDate
        {
            get => _expirationDate;
            set
            {
                ExpirationDateSpecified = true;
                _expirationDate = value;
            }
        }

        [XmlIgnore]
        protected bool ExpirationDateSpecified { get; set; }

        protected List<string> _hostId = new List<string>();

        [XmlElement(ElementName = "hostId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:11634")]
        [MinLength(1)]
        public List<string> HostId
        {
            get => _hostId;
            set
            {
                HostIdSpecified = true;
                _hostId = value;
            }
        }

        [XmlIgnore]
        protected bool HostIdSpecified { get; set; }

        protected List<string> _licenseName = new List<string>();

        [XmlElement(ElementName = "licenseName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:11634")]
        [MinLength(1)]
        public List<string> LicenseName
        {
            get => _licenseName;
            set
            {
                LicenseNameSpecified = true;
                _licenseName = value;
            }
        }

        [XmlIgnore]
        protected bool LicenseNameSpecified { get; set; }

        protected int _numberOfTrunkUsers;

        [XmlElement(ElementName = "numberOfTrunkUsers", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:11634")]
        public int NumberOfTrunkUsers
        {
            get => _numberOfTrunkUsers;
            set
            {
                NumberOfTrunkUsersSpecified = true;
                _numberOfTrunkUsers = value;
            }
        }

        [XmlIgnore]
        protected bool NumberOfTrunkUsersSpecified { get; set; }

        protected string _systemId;

        [XmlElement(ElementName = "systemId", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:11634")]
        public string SystemId
        {
            get => _systemId;
            set
            {
                SystemIdSpecified = true;
                _systemId = value;
            }
        }

        [XmlIgnore]
        protected bool SystemIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.C.OCITable _subscriberLicenseTable;

        [XmlElement(ElementName = "subscriberLicenseTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:11634")]
        public BroadWorksConnector.Ocip.Models.C.OCITable SubscriberLicenseTable
        {
            get => _subscriberLicenseTable;
            set
            {
                SubscriberLicenseTableSpecified = true;
                _subscriberLicenseTable = value;
            }
        }

        [XmlIgnore]
        protected bool SubscriberLicenseTableSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.C.OCITable _groupServiceLicenseTable;

        [XmlElement(ElementName = "groupServiceLicenseTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:11634")]
        public BroadWorksConnector.Ocip.Models.C.OCITable GroupServiceLicenseTable
        {
            get => _groupServiceLicenseTable;
            set
            {
                GroupServiceLicenseTableSpecified = true;
                _groupServiceLicenseTable = value;
            }
        }

        [XmlIgnore]
        protected bool GroupServiceLicenseTableSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.C.OCITable _virtualServiceLicenseTable;

        [XmlElement(ElementName = "virtualServiceLicenseTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:11634")]
        public BroadWorksConnector.Ocip.Models.C.OCITable VirtualServiceLicenseTable
        {
            get => _virtualServiceLicenseTable;
            set
            {
                VirtualServiceLicenseTableSpecified = true;
                _virtualServiceLicenseTable = value;
            }
        }

        [XmlIgnore]
        protected bool VirtualServiceLicenseTableSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.C.OCITable _userServiceLicenseTable;

        [XmlElement(ElementName = "userServiceLicenseTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:11634")]
        public BroadWorksConnector.Ocip.Models.C.OCITable UserServiceLicenseTable
        {
            get => _userServiceLicenseTable;
            set
            {
                UserServiceLicenseTableSpecified = true;
                _userServiceLicenseTable = value;
            }
        }

        [XmlIgnore]
        protected bool UserServiceLicenseTableSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.C.OCITable _systemParamLicenseTable;

        [XmlElement(ElementName = "systemParamLicenseTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:11634")]
        public BroadWorksConnector.Ocip.Models.C.OCITable SystemParamLicenseTable
        {
            get => _systemParamLicenseTable;
            set
            {
                SystemParamLicenseTableSpecified = true;
                _systemParamLicenseTable = value;
            }
        }

        [XmlIgnore]
        protected bool SystemParamLicenseTableSpecified { get; set; }

    }
}
