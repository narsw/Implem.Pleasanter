﻿using Implem.Pleasanter.Libraries.General;
using Implem.Pleasanter.Libraries.Requests;
using Implem.Pleasanter.Libraries.Security;
using Implem.Pleasanter.Libraries.Settings;
namespace Implem.Pleasanter.Models
{
    public static class IssueValidators
    {
        public static Error.Types OnCreating(
            SiteSettings ss, Permissions.Types permissionType, IssueModel issueModel)
        {
            if (!permissionType.CanCreate())
            {
                return Error.Types.HasNotPermission;
            }
            foreach(var controlId in Forms.Keys())
            {
                switch (controlId)
                {
                    case "Issues_Title":
                        if (!ss.GetColumn("Title").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_Body":
                        if (!ss.GetColumn("Body").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_StartTime":
                        if (!ss.GetColumn("StartTime").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CompletionTime":
                        if (!ss.GetColumn("CompletionTime").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_WorkValue":
                        if (!ss.GetColumn("WorkValue").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ProgressRate":
                        if (!ss.GetColumn("ProgressRate").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_Status":
                        if (!ss.GetColumn("Status").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_Manager":
                        if (!ss.GetColumn("Manager").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_Owner":
                        if (!ss.GetColumn("Owner").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassA":
                        if (!ss.GetColumn("ClassA").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassB":
                        if (!ss.GetColumn("ClassB").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassC":
                        if (!ss.GetColumn("ClassC").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassD":
                        if (!ss.GetColumn("ClassD").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassE":
                        if (!ss.GetColumn("ClassE").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassF":
                        if (!ss.GetColumn("ClassF").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassG":
                        if (!ss.GetColumn("ClassG").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassH":
                        if (!ss.GetColumn("ClassH").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassI":
                        if (!ss.GetColumn("ClassI").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassJ":
                        if (!ss.GetColumn("ClassJ").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassK":
                        if (!ss.GetColumn("ClassK").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassL":
                        if (!ss.GetColumn("ClassL").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassM":
                        if (!ss.GetColumn("ClassM").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassN":
                        if (!ss.GetColumn("ClassN").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassO":
                        if (!ss.GetColumn("ClassO").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassP":
                        if (!ss.GetColumn("ClassP").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassQ":
                        if (!ss.GetColumn("ClassQ").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassR":
                        if (!ss.GetColumn("ClassR").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassS":
                        if (!ss.GetColumn("ClassS").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassT":
                        if (!ss.GetColumn("ClassT").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassU":
                        if (!ss.GetColumn("ClassU").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassV":
                        if (!ss.GetColumn("ClassV").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassW":
                        if (!ss.GetColumn("ClassW").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassX":
                        if (!ss.GetColumn("ClassX").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassY":
                        if (!ss.GetColumn("ClassY").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassZ":
                        if (!ss.GetColumn("ClassZ").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumA":
                        if (!ss.GetColumn("NumA").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumB":
                        if (!ss.GetColumn("NumB").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumC":
                        if (!ss.GetColumn("NumC").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumD":
                        if (!ss.GetColumn("NumD").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumE":
                        if (!ss.GetColumn("NumE").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumF":
                        if (!ss.GetColumn("NumF").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumG":
                        if (!ss.GetColumn("NumG").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumH":
                        if (!ss.GetColumn("NumH").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumI":
                        if (!ss.GetColumn("NumI").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumJ":
                        if (!ss.GetColumn("NumJ").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumK":
                        if (!ss.GetColumn("NumK").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumL":
                        if (!ss.GetColumn("NumL").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumM":
                        if (!ss.GetColumn("NumM").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumN":
                        if (!ss.GetColumn("NumN").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumO":
                        if (!ss.GetColumn("NumO").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumP":
                        if (!ss.GetColumn("NumP").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumQ":
                        if (!ss.GetColumn("NumQ").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumR":
                        if (!ss.GetColumn("NumR").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumS":
                        if (!ss.GetColumn("NumS").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumT":
                        if (!ss.GetColumn("NumT").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumU":
                        if (!ss.GetColumn("NumU").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumV":
                        if (!ss.GetColumn("NumV").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumW":
                        if (!ss.GetColumn("NumW").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumX":
                        if (!ss.GetColumn("NumX").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumY":
                        if (!ss.GetColumn("NumY").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumZ":
                        if (!ss.GetColumn("NumZ").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateA":
                        if (!ss.GetColumn("DateA").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateB":
                        if (!ss.GetColumn("DateB").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateC":
                        if (!ss.GetColumn("DateC").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateD":
                        if (!ss.GetColumn("DateD").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateE":
                        if (!ss.GetColumn("DateE").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateF":
                        if (!ss.GetColumn("DateF").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateG":
                        if (!ss.GetColumn("DateG").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateH":
                        if (!ss.GetColumn("DateH").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateI":
                        if (!ss.GetColumn("DateI").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateJ":
                        if (!ss.GetColumn("DateJ").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateK":
                        if (!ss.GetColumn("DateK").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateL":
                        if (!ss.GetColumn("DateL").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateM":
                        if (!ss.GetColumn("DateM").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateN":
                        if (!ss.GetColumn("DateN").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateO":
                        if (!ss.GetColumn("DateO").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateP":
                        if (!ss.GetColumn("DateP").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateQ":
                        if (!ss.GetColumn("DateQ").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateR":
                        if (!ss.GetColumn("DateR").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateS":
                        if (!ss.GetColumn("DateS").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateT":
                        if (!ss.GetColumn("DateT").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateU":
                        if (!ss.GetColumn("DateU").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateV":
                        if (!ss.GetColumn("DateV").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateW":
                        if (!ss.GetColumn("DateW").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateX":
                        if (!ss.GetColumn("DateX").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateY":
                        if (!ss.GetColumn("DateY").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateZ":
                        if (!ss.GetColumn("DateZ").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionA":
                        if (!ss.GetColumn("DescriptionA").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionB":
                        if (!ss.GetColumn("DescriptionB").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionC":
                        if (!ss.GetColumn("DescriptionC").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionD":
                        if (!ss.GetColumn("DescriptionD").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionE":
                        if (!ss.GetColumn("DescriptionE").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionF":
                        if (!ss.GetColumn("DescriptionF").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionG":
                        if (!ss.GetColumn("DescriptionG").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionH":
                        if (!ss.GetColumn("DescriptionH").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionI":
                        if (!ss.GetColumn("DescriptionI").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionJ":
                        if (!ss.GetColumn("DescriptionJ").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionK":
                        if (!ss.GetColumn("DescriptionK").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionL":
                        if (!ss.GetColumn("DescriptionL").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionM":
                        if (!ss.GetColumn("DescriptionM").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionN":
                        if (!ss.GetColumn("DescriptionN").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionO":
                        if (!ss.GetColumn("DescriptionO").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionP":
                        if (!ss.GetColumn("DescriptionP").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionQ":
                        if (!ss.GetColumn("DescriptionQ").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionR":
                        if (!ss.GetColumn("DescriptionR").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionS":
                        if (!ss.GetColumn("DescriptionS").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionT":
                        if (!ss.GetColumn("DescriptionT").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionU":
                        if (!ss.GetColumn("DescriptionU").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionV":
                        if (!ss.GetColumn("DescriptionV").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionW":
                        if (!ss.GetColumn("DescriptionW").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionX":
                        if (!ss.GetColumn("DescriptionX").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionY":
                        if (!ss.GetColumn("DescriptionY").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionZ":
                        if (!ss.GetColumn("DescriptionZ").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckA":
                        if (!ss.GetColumn("CheckA").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckB":
                        if (!ss.GetColumn("CheckB").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckC":
                        if (!ss.GetColumn("CheckC").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckD":
                        if (!ss.GetColumn("CheckD").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckE":
                        if (!ss.GetColumn("CheckE").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckF":
                        if (!ss.GetColumn("CheckF").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckG":
                        if (!ss.GetColumn("CheckG").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckH":
                        if (!ss.GetColumn("CheckH").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckI":
                        if (!ss.GetColumn("CheckI").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckJ":
                        if (!ss.GetColumn("CheckJ").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckK":
                        if (!ss.GetColumn("CheckK").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckL":
                        if (!ss.GetColumn("CheckL").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckM":
                        if (!ss.GetColumn("CheckM").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckN":
                        if (!ss.GetColumn("CheckN").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckO":
                        if (!ss.GetColumn("CheckO").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckP":
                        if (!ss.GetColumn("CheckP").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckQ":
                        if (!ss.GetColumn("CheckQ").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckR":
                        if (!ss.GetColumn("CheckR").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckS":
                        if (!ss.GetColumn("CheckS").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckT":
                        if (!ss.GetColumn("CheckT").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckU":
                        if (!ss.GetColumn("CheckU").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckV":
                        if (!ss.GetColumn("CheckV").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckW":
                        if (!ss.GetColumn("CheckW").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckX":
                        if (!ss.GetColumn("CheckX").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckY":
                        if (!ss.GetColumn("CheckY").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckZ":
                        if (!ss.GetColumn("CheckZ").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_Timestamp":
                        if (!ss.GetColumn("Timestamp").CanCreate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                }
            }
            return Error.Types.None;
        }

        public static Error.Types OnUpdating(
            SiteSettings ss, Permissions.Types permissionType, IssueModel issueModel)
        {
            if (!permissionType.CanUpdate())
            {
                return Error.Types.HasNotPermission;
            }
            foreach(var controlId in Forms.Keys())
            {
                switch (controlId)
                {
                    case "Issues_Title":
                        if (!ss.GetColumn("Title").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_Body":
                        if (!ss.GetColumn("Body").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_StartTime":
                        if (!ss.GetColumn("StartTime").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CompletionTime":
                        if (!ss.GetColumn("CompletionTime").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_WorkValue":
                        if (!ss.GetColumn("WorkValue").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ProgressRate":
                        if (!ss.GetColumn("ProgressRate").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_Status":
                        if (!ss.GetColumn("Status").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_Manager":
                        if (!ss.GetColumn("Manager").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_Owner":
                        if (!ss.GetColumn("Owner").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassA":
                        if (!ss.GetColumn("ClassA").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassB":
                        if (!ss.GetColumn("ClassB").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassC":
                        if (!ss.GetColumn("ClassC").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassD":
                        if (!ss.GetColumn("ClassD").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassE":
                        if (!ss.GetColumn("ClassE").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassF":
                        if (!ss.GetColumn("ClassF").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassG":
                        if (!ss.GetColumn("ClassG").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassH":
                        if (!ss.GetColumn("ClassH").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassI":
                        if (!ss.GetColumn("ClassI").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassJ":
                        if (!ss.GetColumn("ClassJ").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassK":
                        if (!ss.GetColumn("ClassK").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassL":
                        if (!ss.GetColumn("ClassL").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassM":
                        if (!ss.GetColumn("ClassM").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassN":
                        if (!ss.GetColumn("ClassN").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassO":
                        if (!ss.GetColumn("ClassO").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassP":
                        if (!ss.GetColumn("ClassP").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassQ":
                        if (!ss.GetColumn("ClassQ").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassR":
                        if (!ss.GetColumn("ClassR").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassS":
                        if (!ss.GetColumn("ClassS").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassT":
                        if (!ss.GetColumn("ClassT").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassU":
                        if (!ss.GetColumn("ClassU").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassV":
                        if (!ss.GetColumn("ClassV").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassW":
                        if (!ss.GetColumn("ClassW").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassX":
                        if (!ss.GetColumn("ClassX").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassY":
                        if (!ss.GetColumn("ClassY").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_ClassZ":
                        if (!ss.GetColumn("ClassZ").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumA":
                        if (!ss.GetColumn("NumA").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumB":
                        if (!ss.GetColumn("NumB").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumC":
                        if (!ss.GetColumn("NumC").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumD":
                        if (!ss.GetColumn("NumD").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumE":
                        if (!ss.GetColumn("NumE").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumF":
                        if (!ss.GetColumn("NumF").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumG":
                        if (!ss.GetColumn("NumG").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumH":
                        if (!ss.GetColumn("NumH").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumI":
                        if (!ss.GetColumn("NumI").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumJ":
                        if (!ss.GetColumn("NumJ").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumK":
                        if (!ss.GetColumn("NumK").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumL":
                        if (!ss.GetColumn("NumL").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumM":
                        if (!ss.GetColumn("NumM").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumN":
                        if (!ss.GetColumn("NumN").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumO":
                        if (!ss.GetColumn("NumO").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumP":
                        if (!ss.GetColumn("NumP").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumQ":
                        if (!ss.GetColumn("NumQ").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumR":
                        if (!ss.GetColumn("NumR").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumS":
                        if (!ss.GetColumn("NumS").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumT":
                        if (!ss.GetColumn("NumT").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumU":
                        if (!ss.GetColumn("NumU").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumV":
                        if (!ss.GetColumn("NumV").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumW":
                        if (!ss.GetColumn("NumW").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumX":
                        if (!ss.GetColumn("NumX").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumY":
                        if (!ss.GetColumn("NumY").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_NumZ":
                        if (!ss.GetColumn("NumZ").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateA":
                        if (!ss.GetColumn("DateA").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateB":
                        if (!ss.GetColumn("DateB").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateC":
                        if (!ss.GetColumn("DateC").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateD":
                        if (!ss.GetColumn("DateD").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateE":
                        if (!ss.GetColumn("DateE").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateF":
                        if (!ss.GetColumn("DateF").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateG":
                        if (!ss.GetColumn("DateG").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateH":
                        if (!ss.GetColumn("DateH").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateI":
                        if (!ss.GetColumn("DateI").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateJ":
                        if (!ss.GetColumn("DateJ").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateK":
                        if (!ss.GetColumn("DateK").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateL":
                        if (!ss.GetColumn("DateL").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateM":
                        if (!ss.GetColumn("DateM").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateN":
                        if (!ss.GetColumn("DateN").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateO":
                        if (!ss.GetColumn("DateO").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateP":
                        if (!ss.GetColumn("DateP").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateQ":
                        if (!ss.GetColumn("DateQ").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateR":
                        if (!ss.GetColumn("DateR").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateS":
                        if (!ss.GetColumn("DateS").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateT":
                        if (!ss.GetColumn("DateT").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateU":
                        if (!ss.GetColumn("DateU").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateV":
                        if (!ss.GetColumn("DateV").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateW":
                        if (!ss.GetColumn("DateW").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateX":
                        if (!ss.GetColumn("DateX").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateY":
                        if (!ss.GetColumn("DateY").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DateZ":
                        if (!ss.GetColumn("DateZ").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionA":
                        if (!ss.GetColumn("DescriptionA").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionB":
                        if (!ss.GetColumn("DescriptionB").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionC":
                        if (!ss.GetColumn("DescriptionC").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionD":
                        if (!ss.GetColumn("DescriptionD").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionE":
                        if (!ss.GetColumn("DescriptionE").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionF":
                        if (!ss.GetColumn("DescriptionF").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionG":
                        if (!ss.GetColumn("DescriptionG").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionH":
                        if (!ss.GetColumn("DescriptionH").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionI":
                        if (!ss.GetColumn("DescriptionI").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionJ":
                        if (!ss.GetColumn("DescriptionJ").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionK":
                        if (!ss.GetColumn("DescriptionK").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionL":
                        if (!ss.GetColumn("DescriptionL").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionM":
                        if (!ss.GetColumn("DescriptionM").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionN":
                        if (!ss.GetColumn("DescriptionN").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionO":
                        if (!ss.GetColumn("DescriptionO").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionP":
                        if (!ss.GetColumn("DescriptionP").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionQ":
                        if (!ss.GetColumn("DescriptionQ").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionR":
                        if (!ss.GetColumn("DescriptionR").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionS":
                        if (!ss.GetColumn("DescriptionS").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionT":
                        if (!ss.GetColumn("DescriptionT").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionU":
                        if (!ss.GetColumn("DescriptionU").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionV":
                        if (!ss.GetColumn("DescriptionV").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionW":
                        if (!ss.GetColumn("DescriptionW").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionX":
                        if (!ss.GetColumn("DescriptionX").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionY":
                        if (!ss.GetColumn("DescriptionY").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_DescriptionZ":
                        if (!ss.GetColumn("DescriptionZ").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckA":
                        if (!ss.GetColumn("CheckA").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckB":
                        if (!ss.GetColumn("CheckB").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckC":
                        if (!ss.GetColumn("CheckC").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckD":
                        if (!ss.GetColumn("CheckD").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckE":
                        if (!ss.GetColumn("CheckE").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckF":
                        if (!ss.GetColumn("CheckF").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckG":
                        if (!ss.GetColumn("CheckG").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckH":
                        if (!ss.GetColumn("CheckH").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckI":
                        if (!ss.GetColumn("CheckI").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckJ":
                        if (!ss.GetColumn("CheckJ").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckK":
                        if (!ss.GetColumn("CheckK").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckL":
                        if (!ss.GetColumn("CheckL").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckM":
                        if (!ss.GetColumn("CheckM").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckN":
                        if (!ss.GetColumn("CheckN").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckO":
                        if (!ss.GetColumn("CheckO").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckP":
                        if (!ss.GetColumn("CheckP").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckQ":
                        if (!ss.GetColumn("CheckQ").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckR":
                        if (!ss.GetColumn("CheckR").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckS":
                        if (!ss.GetColumn("CheckS").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckT":
                        if (!ss.GetColumn("CheckT").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckU":
                        if (!ss.GetColumn("CheckU").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckV":
                        if (!ss.GetColumn("CheckV").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckW":
                        if (!ss.GetColumn("CheckW").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckX":
                        if (!ss.GetColumn("CheckX").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckY":
                        if (!ss.GetColumn("CheckY").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_CheckZ":
                        if (!ss.GetColumn("CheckZ").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                    case "Issues_Timestamp":
                        if (!ss.GetColumn("Timestamp").CanUpdate(permissionType))
                        {
                            return Error.Types.InvalidRequest;
                        }
                        break;
                }
            }
            return Error.Types.None;
        }

        public static Error.Types OnMoving(Permissions.Types source, Permissions.Types destination)
        {
            if (!Permissions.CanMove(source, destination))
            {
                return Error.Types.HasNotPermission;
            }
            return Error.Types.None;
        }

        public static Error.Types OnDeleting(
            SiteSettings ss, Permissions.Types permissionType, IssueModel issueModel)
        {
            if (!permissionType.CanDelete())
            {
                return Error.Types.HasNotPermission;
            }
            return Error.Types.None;
        }

        public static Error.Types OnRestoring()
        {
            if (!Permissions.Admins().CanEditTenant())
            {
                return Error.Types.HasNotPermission;
            }
            return Error.Types.None;
        }
    }
}
