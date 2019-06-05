using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SortOrderGroupPhoneDirectoryGetPagedSortedList 
{
    private BroadworksConnector.Ocip.Models.SortByUserLastName _sortByUserLastName;

    [XmlElement(ElementName = "sortByUserLastName", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SortByUserLastName SortByUserLastName {
        get => _sortByUserLastName;
        set {
            SortByUserLastNameSpecified = true;
            _sortByUserLastName = value;
        }
    }

    [XmlIgnore]
    public bool SortByUserLastNameSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SortByUserFirstName _sortByUserFirstName;

    [XmlElement(ElementName = "sortByUserFirstName", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SortByUserFirstName SortByUserFirstName {
        get => _sortByUserFirstName;
        set {
            SortByUserFirstNameSpecified = true;
            _sortByUserFirstName = value;
        }
    }

    [XmlIgnore]
    public bool SortByUserFirstNameSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SortByMobilePhoneNumber _sortByMobilePhoneNumber;

    [XmlElement(ElementName = "sortByMobilePhoneNumber", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SortByMobilePhoneNumber SortByMobilePhoneNumber {
        get => _sortByMobilePhoneNumber;
        set {
            SortByMobilePhoneNumberSpecified = true;
            _sortByMobilePhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool SortByMobilePhoneNumberSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SortByEmailAddress _sortByEmailAddress;

    [XmlElement(ElementName = "sortByEmailAddress", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SortByEmailAddress SortByEmailAddress {
        get => _sortByEmailAddress;
        set {
            SortByEmailAddressSpecified = true;
            _sortByEmailAddress = value;
        }
    }

    [XmlIgnore]
    public bool SortByEmailAddressSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SortByDepartmentName _sortByDepartmentName;

    [XmlElement(ElementName = "sortByDepartmentName", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SortByDepartmentName SortByDepartmentName {
        get => _sortByDepartmentName;
        set {
            SortByDepartmentNameSpecified = true;
            _sortByDepartmentName = value;
        }
    }

    [XmlIgnore]
    public bool SortByDepartmentNameSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SortByYahooId _sortByYahooId;

    [XmlElement(ElementName = "sortByYahooId", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SortByYahooId SortByYahooId {
        get => _sortByYahooId;
        set {
            SortByYahooIdSpecified = true;
            _sortByYahooId = value;
        }
    }

    [XmlIgnore]
    public bool SortByYahooIdSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SortByUserId _sortByUserId;

    [XmlElement(ElementName = "sortByUserId", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SortByUserId SortByUserId {
        get => _sortByUserId;
        set {
            SortByUserIdSpecified = true;
            _sortByUserId = value;
        }
    }

    [XmlIgnore]
    public bool SortByUserIdSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SortByImpId _sortByImpId;

    [XmlElement(ElementName = "sortByImpId", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SortByImpId SortByImpId {
        get => _sortByImpId;
        set {
            SortByImpIdSpecified = true;
            _sortByImpId = value;
        }
    }

    [XmlIgnore]
    public bool SortByImpIdSpecified { get; set; }
}
}
