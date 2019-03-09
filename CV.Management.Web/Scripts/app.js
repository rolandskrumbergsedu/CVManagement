﻿$(document).ready(function () {

    $('.remove-image').click(function () {
        var row = $(this).closest('tr');
        var hiddenInput = row.find("input");
        var hiddenInputValue = hiddenInput.attr("value");

        $.get(window.location.origin + "/api/delete/" + hiddenInputValue, function (data) {

            row.remove();

        }).fail(function () {
            alert("Error deleting file!");
        });

    });

    $('.education-now-input').each(function () {
        var formGroup = $(this).closest('div[class^="form-group"]');
        if (this.checked) {
            formGroup.find(".education-to-year-input").attr("disabled", "true");
        } else {
            formGroup.find(".education-to-year-input").removeAttr("disabled");
        }
    });

    $('.membership-now-input').each(function () {
        var formGroup = $(this).closest('div[class^="form-group"]');
        if (this.checked) {
            formGroup.find(".membership-to-time-input").attr("disabled", "true");
        } else {
            formGroup.find(".membership-to-time-input").removeAttr("disabled");
        }

    });

    $('.career-position-now-input').each(function () {
        var formGroup = $(this).closest('div[class^="form-group"]');
        if (this.checked) {
            formGroup.find(".position-to-time-input").attr("disabled", "true");
        } else {
            formGroup.find(".position-to-time-input").removeAttr("disabled");
        }
    });

    $('.education-now-input').change(function () {
        var formGroup = $(this).closest('div[class^="form-group"]');
        if (this.checked) {
            formGroup.find(".education-to-year-input").attr("disabled", "true");
            formGroup.find(".education-to-year-input").attr("value", "");
        } else {
            formGroup.find(".education-to-year-input").removeAttr("disabled");
        }
        
    });

    $('.membership-now-input').change(function () {
        var formGroup = $(this).closest('div[class^="form-group"]');
        if (this.checked) {
            formGroup.find(".membership-to-time-input").attr("disabled", "true");
            formGroup.find(".membership-to-time-input").attr("value", "");
        } else {
            formGroup.find(".membership-to-time-input").removeAttr("disabled");
        }

    });

    $('.career-position-now-input').change(function () {
        var formGroup = $(this).closest('div[class^="form-group"]');
        if (this.checked) {
            formGroup.find(".position-to-time-input").attr("value", null);
            formGroup.find(".position-to-time-input").attr("disabled", "true");
        } else {
            formGroup.find(".position-to-time-input").removeAttr("disabled");
        }
    });

    $('.company-industry-select').each(function () {

        var row = $(this).closest('div[class^="row"]');

        if (this.value !== "22") {
            row.find(".company-other-industry-input").attr("value", null);
            row.find(".company-other-industry-input").attr("disabled", "true");
        } else {
            row.find(".company-other-industry-input").removeAttr("disabled");
        }

    });

    $('.company-industry-select').change(function () {

        var row = $(this).closest('div[class^="row"]');

        if (this.value !== "22") {
            row.find(".company-other-industry-input").attr("disabled", "true");
            row.find(".company-other-industry-input").attr("value", "");
        } else {
            row.find(".company-other-industry-input").removeAttr("disabled");
        }

    });

    function updateEducationFieldNumbers() {

        var formName = "Education";
        var fromYearFieldName = "FromYear";
        var toYearFieldName = "ToYear";
        var institutionFieldName = "Institution";
        var degreeFieldName = "Degree";

        $(".education_row").each(function (index) {

            $(this).find(".education-from-year-label").attr("for", formName + "_" + index + "__" + fromYearFieldName);
            $(this).find(".education-from-year-input").attr({
                "id": formName + "_" + index + "__" + fromYearFieldName,
                "name": formName + "[" + index + "]." + fromYearFieldName
            });
            $(this).find(".education-from-year-validation").attr("data-valmsg-for", formName + "[" + index + "]." + fromYearFieldName);

            $(this).find(".education-to-year-label").attr("for", formName + "_" + index + "__" + toYearFieldName);
            $(this).find(".education-to-year-input").attr({
                "id": formName + "_" + index + "__" + toYearFieldName,
                "name": formName + "[" + index + "]." + toYearFieldName
            });
            $(this).find(".education-to-year-validation").attr("data-valmsg-for", formName + "[" + index + "]." + toYearFieldName);

            $(this).find(".education-institution-label").attr("for", formName + "_" + index + "__" + institutionFieldName);
            $(this).find(".education-institution-input").attr({
                "id": formName + "_" + index + "__" + institutionFieldName,
                "name": formName + "[" + index + "]." + institutionFieldName
            });
            $(this).find(".education-institution-validation").attr("data-valmsg-for", formName + "[" + index + "]." + institutionFieldName);

            $(this).find(".education-degree-label").attr("for", formName + "_" + index + "__" + degreeFieldName);
            $(this).find(".education-degree-input").attr({
                "id": formName + "_" + index + "__" + degreeFieldName,
                "name": formName + "[" + index + "]." + degreeFieldName
            });
            $(this).find(".education-degree-validation").attr("data-valmsg-for", formName + "[" + index + "]." + degreeFieldName);

        });
    }
    function removeEducation() {
            $(this).closest('div[class^="education_row"]').remove();

            updateEducationFieldNumbers();
    }

    $("#education_add").click(function () {
        var existingEducationRowCount = $(".education_row").length;
        var lastEducationRow = $(".education_row").last();
        var newRow = lastEducationRow.clone();

        var formName = "Education";
        var fromYearFieldName = "FromYear";
        var toYearFieldName = "ToYear";
        var institutionFieldName = "Institution";
        var degreeFieldName = "Degree";

        newRow.find(".education-from-year-label").attr("for", formName + "_" + existingEducationRowCount + "__" + fromYearFieldName);
        newRow.find(".education-from-year-input").attr({
            "id": formName + "_" + existingEducationRowCount + "__" + fromYearFieldName,
            "name": formName + "[" + existingEducationRowCount + "]." + fromYearFieldName,
            "value": null
        });
        newRow.find(".education-from-year-label").attr("data-valmsg-for", formName + "[" + existingEducationRowCount + "]." + fromYearFieldName);

        newRow.find(".education-to-year-label").attr("for", formName + "_" + existingEducationRowCount + "__" + toYearFieldName);
        newRow.find(".education-to-year-input").attr({
            "id": formName + "_" + existingEducationRowCount + "__" + toYearFieldName,
            "name": formName + "[" + existingEducationRowCount + "]." + toYearFieldName,
            "value": null
        });
        newRow.find(".education-to-year-label").attr("data-valmsg-for", formName + "[" + existingEducationRowCount + "]." + toYearFieldName);

        newRow.find(".education-institution-label").attr("for", formName + "_" + existingEducationRowCount + "__" + institutionFieldName);
        newRow.find(".education-institution-input").attr({
            "id": formName + "_" + existingEducationRowCount + "__" + institutionFieldName,
            "name": formName + "[" + existingEducationRowCount + "]." + institutionFieldName,
            "value": null
        });
        newRow.find(".education-institution-label").attr("data-valmsg-for", formName + "[" + existingEducationRowCount + "]." + institutionFieldName);

        newRow.find(".education-degree-label").attr("for", formName + "_" + existingEducationRowCount + "__" + degreeFieldName);
        newRow.find(".education-degree-input").attr({
            "id": formName + "_" + existingEducationRowCount + "__" + degreeFieldName,
            "name": formName + "[" + existingEducationRowCount + "]." + degreeFieldName,
            "value": null
        });
        newRow.find(".education-degree-label").attr("data-valmsg-for", formName + "[" + existingEducationRowCount + "]." + degreeFieldName);

        newRow.find(".education-remove").click(removeEducation);

        $("#education_container").append(newRow);
    });

    $(".education-remove").click(removeEducation);

    function updateAdditionalCoursesFieldNumbers() {

        var formName = "Courses";
        var numberOfDaysFieldName = "NumberOfDays";
        var yearFieldName = "Year";
        var courseNameFieldName = "CourseName";
        var trainerFieldName = "Trainer";

        $(".courses_row").each(function (index) {

            $(this).find(".courses-number-of-days-label").attr("for", formName + "_" + index + "__" + numberOfDaysFieldName);
            $(this).find(".courses-number-of-days-input").attr({
                "id": formName + "_" + index + "__" + numberOfDaysFieldName,
                "name": formName + "[" + index + "]." + numberOfDaysFieldName
            });
            $(this).find(".courses-number-of-days-validation").attr("data-valmsg-for", formName + "[" + index + "]." + numberOfDaysFieldName);

            $(this).find(".courses-year-label").attr("for", formName + "_" + index + "__" + yearFieldName);
            $(this).find(".courses-year-input").attr({
                "id": formName + "_" + index + "__" + yearFieldName,
                "name": formName + "[" + index + "]." + yearFieldName
            });
            $(this).find(".courses-year-validation").attr("data-valmsg-for", formName + "[" + index + "]." + yearFieldName);

            $(this).find(".courses-name-label").attr("for", formName + "_" + index + "__" + courseNameFieldName);
            $(this).find(".courses-name-input").attr({
                "id": formName + "_" + index + "__" + courseNameFieldName,
                "name": formName + "[" + index + "]." + courseNameFieldName
            });
            $(this).find(".courses-name-validation").attr("data-valmsg-for", formName + "[" + index + "]." + courseNameFieldName);

            $(this).find(".courses-trainer-label").attr("for", formName + "_" + index + "__" + trainerFieldName);
            $(this).find(".courses-trainer-input").attr({
                "id": formName + "_" + index + "__" + trainerFieldName,
                "name": formName + "[" + index + "]." + trainerFieldName
            });
            $(this).find(".courses-trainer-validation").attr("data-valmsg-for", formName + "[" + index + "]." + trainerFieldName);

        });

    }
    function removeAdditionalCourse() {
        $(this).closest('div[class^="courses_row"]').remove();

        updateAdditionalCoursesFieldNumbers();
    }

    $("#additional_course_add").click(function () {
        var index = $(".courses_row").length;
        var lastAddittionalCoursesRow = $(".courses_row").last();
        var newRow = lastAddittionalCoursesRow.clone();

        var formName = "Courses";
        var numberOfDaysFieldName = "NumberOfDays";
        var yearFieldName = "Year";
        var courseNameFieldName = "CourseName";
        var trainerFieldName = "Trainer";

        newRow.find(".courses-number-of-days-label").attr("for", formName + "_" + index + "__" + numberOfDaysFieldName);
        newRow.find(".courses-number-of-days-input").attr({
            "id": formName + "_" + index + "__" + numberOfDaysFieldName,
            "name": formName + "[" + index + "]." + numberOfDaysFieldName,
            "value": null
        });
        newRow.find(".courses-number-of-days-validation").attr("data-valmsg-for", formName + "[" + index + "]." + numberOfDaysFieldName);

        newRow.find(".courses-year-label").attr("for", formName + "_" + index + "__" + yearFieldName);
        newRow.find(".courses-year-input").attr({
            "id": formName + "_" + index + "__" + yearFieldName,
            "name": formName + "[" + index + "]." + yearFieldName,
            "value": null
        });
        newRow.find(".courses-year-validation").attr("data-valmsg-for", formName + "[" + index + "]." + yearFieldName);

        newRow.find(".courses-name-label").attr("for", formName + "_" + index + "__" + courseNameFieldName);
        newRow.find(".courses-name-input").attr({
            "id": formName + "_" + index + "__" + courseNameFieldName,
            "name": formName + "[" + index + "]." + courseNameFieldName,
            "value": null
        });
        newRow.find(".courses-name-validation").attr("data-valmsg-for", formName + "[" + index + "]." + courseNameFieldName);

        newRow.find(".courses-trainer-label").attr("for", formName + "_" + index + "__" + trainerFieldName);
        newRow.find(".courses-trainer-input").attr({
            "id": formName + "_" + index + "__" + trainerFieldName,
            "name": formName + "[" + index + "]." + trainerFieldName,
            "value": null
        });
        newRow.find(".courses-trainer-validation").attr("data-valmsg-for", formName + "[" + index + "]." + trainerFieldName);

        newRow.find(".courses-remove").click(removeAdditionalCourse);

        $("#courses_container").append(newRow);
    });

    $(".courses-remove").click(removeAdditionalCourse);

    function updateLanguagesFieldNumbers() {

        var formName = "Languages";
        var languageNameFieldName = "LanguageName";
        var spokenLevelFieldName = "SpokenLevel";
        var writtenLevelFieldName = "WrittenLevel";

        $(".language_row").each(function (index) {

            $(this).find(".language-name-label").attr("for", formName + "_" + index + "__" + languageNameFieldName);
            $(this).find(".language-name-input").attr({
                "id": formName + "_" + index + "__" + languageNameFieldName,
                "name": formName + "[" + index + "]." + languageNameFieldName
            });
            $(this).find(".language-name-validation").attr("data-valmsg-for", formName + "[" + index + "]." + languageNameFieldName);

            $(this).find(".language-spoken-label").attr("for", formName + "_" + index + "__" + spokenLevelFieldName);
            $(this).find(".language-spoken-input").attr({
                "id": formName + "_" + index + "__" + spokenLevelFieldName,
                "name": formName + "[" + index + "]." + spokenLevelFieldName
            });
            $(this).find(".language-spoken-validation").attr("data-valmsg-for", formName + "[" + index + "]." + spokenLevelFieldName);

            $(this).find(".language-written-label").attr("for", formName + "_" + index + "__" + writtenLevelFieldName);
            $(this).find(".language-written-input").attr({
                "id": formName + "_" + index + "__" + writtenLevelFieldName,
                "name": formName + "[" + index + "]." + writtenLevelFieldName
            });
            $(this).find(".language-written-validation").attr("data-valmsg-for", formName + "[" + index + "]." + writtenLevelFieldName);
            
        });

    }
    function removeLanguage() {
        $(this).closest('div[class^="language_row"]').remove();

        updateLanguagesFieldNumbers();
    }

    $("#language_add").click(function () {
        var index = $(".language_row").length;
        var lastLanguageRow = $(".language_row").last();
        var newRow = lastLanguageRow.clone();

        var formName = "Languages";
        var languageNameFieldName = "LanguageName";
        var spokenLevelFieldName = "SpokenLevel";
        var writtenLevelFieldName = "WrittenLevel";

        newRow.find(".language-name-label").attr("for", formName + "_" + index + "__" + languageNameFieldName);
        newRow.find(".language-name-select").attr({
            "id": formName + "_" + index + "__" + languageNameFieldName,
            "name": formName + "[" + index + "]." + languageNameFieldName
        });
        newRow.find(".language-name-select option[selected='selected']").removeAttr("selected");
        newRow.find(".language-name-validation").attr("data-valmsg-for", formName + "[" + index + "]." + languageNameFieldName);

        newRow.find(".language-spoken-label").attr("for", formName + "_" + index + "__" + spokenLevelFieldName);
        newRow.find(".language-spoken-select").attr({
            "id": formName + "_" + index + "__" + spokenLevelFieldName,
            "name": formName + "[" + index + "]." + spokenLevelFieldName
        });
        newRow.find(".language-spoken-select option[selected='selected']").removeAttr("selected");
        newRow.find(".language-spoken-validation").attr("data-valmsg-for", formName + "[" + index + "]." + spokenLevelFieldName);

        newRow.find(".language-written-label").attr("for", formName + "_" + index + "__" + writtenLevelFieldName);
        newRow.find(".language-written-select").attr({
            "id": formName + "_" + index + "__" + writtenLevelFieldName,
            "name": formName + "[" + index + "]." + writtenLevelFieldName
        });
        newRow.find(".language-written-select option[selected='selected']").removeAttr("selected");
        newRow.find(".language-written-validation").attr("data-valmsg-for", formName + "[" + index + "]." + writtenLevelFieldName);

        newRow.find(".language-remove").click(removeLanguage);

        $("#language_container").append(newRow);
    });

    $(".language-remove").click(removeLanguage);

    function updateMembershipFieldNumbers() {

        var formName = "Memberships";
        var fromTimeFieldName = "FromTime";
        var toTimeFieldName = "ToTime";
        var descriptionFieldName = "Description";

        $(".membership_row").each(function (index) {

            $(this).find(".membership-from-time-label").attr("for", formName + "_" + index + "__" + fromTimeFieldName);
            $(this).find(".membership-from-time-input").attr({
                "id": formName + "_" + index + "__" + fromTimeFieldName,
                "name": formName + "[" + index + "]." + fromTimeFieldName
            });
            $(this).find(".membership-from-time-validation").attr("data-valmsg-for", formName + "[" + index + "]." + fromTimeFieldName);

            $(this).find(".membership-to-time-label").attr("for", formName + "_" + index + "__" + toTimeFieldName);
            $(this).find(".membership-to-time-input").attr({
                "id": formName + "_" + index + "__" + toTimeFieldName,
                "name": formName + "[" + index + "]." + toTimeFieldName
            });
            $(this).find(".membership-to-time-validation").attr("data-valmsg-for", formName + "[" + index + "]." + toTimeFieldName);

            $(this).find(".membership-description-label").attr("for", formName + "_" + index + "__" + descriptionFieldName);
            $(this).find(".membership-description-input").attr({
                "id": formName + "_" + index + "__" + descriptionFieldName,
                "name": formName + "[" + index + "]." + descriptionFieldName
            });
            $(this).find(".membership-description-validation").attr("data-valmsg-for", formName + "[" + index + "]." + descriptionFieldName);

        });
    }
    function removeMembership() {
        $(this).closest('div[class^="membership_row"]').remove();

        updateMembershipFieldNumbers();
    }

    $("#membership_add").click(function () {
        var existingMembershipRowCount = $(".membership_row").length;
        var lastMembershipRow = $(".membership_row").last();
        var newRow = lastMembershipRow.clone();

        var formName = "Memberships";
        var fromTimeFieldName = "FromTime";
        var toTimeFieldName = "ToTime";
        var descriptionFieldName = "Description";

        newRow.find(".membership-from-time-label").attr("for", formName + "_" + existingMembershipRowCount + "__" + fromTimeFieldName);
        newRow.find(".membership-from-time-input").attr({
            "id": formName + "_" + existingMembershipRowCount + "__" + fromTimeFieldName,
            "name": formName + "[" + existingMembershipRowCount + "]." + fromTimeFieldName,
            "value": null
        });
        newRow.find(".membership-from-time-label").attr("data-valmsg-for", formName + "[" + existingMembershipRowCount + "]." + fromTimeFieldName);

        newRow.find(".membership-to-time-label").attr("for", formName + "_" + existingMembershipRowCount + "__" + toTimeFieldName);
        newRow.find(".membership-to-time-input").attr({
            "id": formName + "_" + existingMembershipRowCount + "__" + toTimeFieldName,
            "name": formName + "[" + existingMembershipRowCount + "]." + toTimeFieldName,
            "value": null
        });
        newRow.find(".membership-to-time-label").attr("data-valmsg-for", formName + "[" + existingMembershipRowCount + "]." + toTimeFieldName);

        newRow.find(".membership-description-label").attr("for", formName + "_" + existingMembershipRowCount + "__" + descriptionFieldName);
        newRow.find(".membership-description-input").attr({
            "id": formName + "_" + existingMembershipRowCount + "__" + descriptionFieldName,
            "name": formName + "[" + existingMembershipRowCount + "]." + descriptionFieldName
        });
        newRow.find(".membership-description-input").val(null);
        newRow.find(".membership-description-label").attr("data-valmsg-for", formName + "[" + existingMembershipRowCount + "]." + descriptionFieldName);

        newRow.find(".membership-remove").click(removeMembership);

        $("#membership_container").append(newRow);
    });

    $(".membership-remove").click(removeMembership);

    function updateCompanyFieldNumbers() {

        var companyFormName = "Companies";
        var companyNameFieldName = "Name";
        var companyCityFieldName = "City";
        var companyParentCompanyFieldName = "ParentCompanyName";
        var companyIndustryFieldName = "Industry";
        var companyOtherIndustryFieldName = "OtherIndustry";
        var companyMainProductionsFieldName = "MainProductions";
        var companyTurnoverFieldName = "Turnover";
        var companyEmployeesFieldName = "NumberOfEmployees";
        var positionFormName = "Positions";
        var positionNameFieldName = "Name";
        var positionFromTimeFieldName = "FromTime";
        var positionToTimeFieldName = "ToTime";
        var positionNowFieldName = "Now";
        var positionKeyTasks = "KeyTasks";
        var positionReportingToFieldName = "ReportingTo";
        var positionDirectSubordinatesFieldName = "DirectSubordinates";
        var positionAchievementsFieldName = "Achievements";
        var positionReasonForLeavingFieldName = "ReasonForLeaving";

        $(".company_row").each(function (companyIndex) {

            $(this).find(".company-number").text(companyIndex + 1);

            $(this).find(".company-name-label").attr("for", companyFormName + "_" + companyIndex + "__" + companyNameFieldName);
            $(this).find(".company-name-input").attr({
                "id": companyFormName + "_" + companyIndex + "__" + companyNameFieldName,
                "name": companyFormName + "[" + companyIndex + "]." + companyNameFieldName
            });
            $(this).find(".company-name-validation").attr("data-valmsg-for", companyFormName + "[" + companyIndex + "]." + companyNameFieldName);

            $(this).find(".company-city-label").attr("for", companyFormName + "_" + companyIndex + "__" + companyCityFieldName);
            $(this).find(".company-city-input").attr({
                "id": companyFormName + "_" + companyIndex + "__" + companyCityFieldName,
                "name": companyFormName + "[" + companyIndex + "]." + companyCityFieldName
            });
            $(this).find(".company-city-validation").attr("data-valmsg-for", companyFormName + "[" + companyIndex + "]." + companyCityFieldName);

            $(this).find(".company-parent-company-label").attr("for", companyFormName + "_" + companyIndex + "__" + companyParentCompanyFieldName);
            $(this).find(".company-parent-company-input").attr({
                "id": companyFormName + "_" + companyIndex + "__" + companyParentCompanyFieldName,
                "name": companyFormName + "[" + companyIndex + "]." + companyParentCompanyFieldName
            });
            $(this).find(".company-parent-company-validation").attr("data-valmsg-for", companyFormName + "[" + companyIndex + "]." + companyParentCompanyFieldName);

            $(this).find(".company-industry-label").attr("for", companyFormName + "_" + companyIndex + "__" + companyIndustryFieldName);
            $(this).find(".company-industry-select").attr({
                "id": companyFormName + "_" + companyIndex + "__" + companyIndustryFieldName,
                "name": companyFormName + "[" + companyIndex + "]." + companyIndustryFieldName
            });
            $(this).find(".company-industry-validation").attr("data-valmsg-for", companyFormName + "[" + companyIndex + "]." + companyIndustryFieldName);

            $(this).find(".company-other-industry-label").attr("for", companyFormName + "_" + companyIndex + "__" + companyOtherIndustryFieldName);
            $(this).find(".company-other-industry-input").attr({
                "id": companyFormName + "_" + companyIndex + "__" + companyOtherIndustryFieldName,
                "name": companyFormName + "[" + companyIndex + "]." + companyOtherIndustryFieldName
            });
            $(this).find(".company-other-industry-validation").attr("data-valmsg-for", companyFormName + "[" + companyIndex + "]." + companyOtherIndustryFieldName);

            $(this).find(".company-productions-label").attr("for", companyFormName + "_" + companyIndex + "__" + companyMainProductionsFieldName);
            $(this).find(".company-productions-input").attr({
                "id": companyFormName + "_" + companyIndex + "__" + companyMainProductionsFieldName,
                "name": companyFormName + "[" + companyIndex + "]." + companyMainProductionsFieldName
            });
            $(this).find(".company-productions-validation").attr("data-valmsg-for", companyFormName + "[" + companyIndex + "]." + companyMainProductionsFieldName);

            $(this).find(".company-turnover-label").attr("for", companyFormName + "_" + companyIndex + "__" + companyTurnoverFieldName);
            $(this).find(".company-turnover-input").attr({
                "id": companyFormName + "_" + companyIndex + "__" + companyTurnoverFieldName,
                "name": companyFormName + "[" + companyIndex + "]." + companyTurnoverFieldName
            });
            $(this).find(".company-turnover-validation").attr("data-valmsg-for", companyFormName + "[" + companyIndex + "]." + companyTurnoverFieldName);

            $(this).find(".company-employees-label").attr("for", companyFormName + "_" + companyIndex + "__" + companyEmployeesFieldName);
            $(this).find(".company-employees-input").attr({
                "id": companyFormName + "_" + companyIndex + "__" + companyEmployeesFieldName,
                "name": companyFormName + "[" + companyIndex + "]." + companyEmployeesFieldName
            });
            $(this).find(".company-employees-validation").attr("data-valmsg-for", companyFormName + "[" + companyIndex + "]." + companyEmployeesFieldName);

            $(this).find(".position_row").each(function (positionIndex) {

                $(this).find(".position-number").text(positionIndex + 1);

                $(this).find(".position-name-label").attr("for", companyFormName + "_" + companyIndex + "__" + positionFormName + "_" + positionIndex + "__" + positionNameFieldName);
                $(this).find(".position-name-input").attr({
                    "id": companyFormName + "_" + companyIndex + "__" + positionFormName + "_" + positionIndex + "__" + positionNameFieldName,
                    "name": companyFormName + "[" + companyIndex + "]." + positionFormName + "[" + positionIndex + "]." + positionNameFieldName
                });
                $(this).find(".position-name-validation").attr("data-valmsg-for", companyFormName + "[" + companyIndex + "]." + positionFormName + "[" + positionIndex + "]." + positionNameFieldName);

                $(this).find(".position-from-time-label").attr("for", companyFormName + "_" + companyIndex + "__" + positionFormName + "_" + positionIndex + "__" + positionFromTimeFieldName);
                $(this).find(".position-from-time-input").attr({
                    "id": companyFormName + "_" + companyIndex + "__" + positionFormName + "_" + positionIndex + "__" + positionFromTimeFieldName,
                    "name": companyFormName + "[" + companyIndex + "]." + positionFormName + "[" + positionIndex + "]." + positionFromTimeFieldName
                });
                $(this).find(".position-from-time-validation").attr("data-valmsg-for", companyFormName + "[" + companyIndex + "]." + positionFormName + "[" + positionIndex + "]." + positionFromTimeFieldName);

                $(this).find(".position-to-time-label").attr("for", companyFormName + "_" + companyIndex + "__" + positionFormName + "_" + positionIndex + "__" + positionToTimeFieldName);
                $(this).find(".position-to-time-input").attr({
                    "id": companyFormName + "_" + companyIndex + "__" + positionFormName + "_" + positionIndex + "__" + positionToTimeFieldName,
                    "name": companyFormName + "[" + companyIndex + "]." + positionFormName + "[" + positionIndex + "]." + positionToTimeFieldName
                });
                $(this).find(".position-to-time-validation").attr("data-valmsg-for", companyFormName + "[" + companyIndex + "]." + positionFormName + "[" + positionIndex + "]." + positionToTimeFieldName);

                $(this).find(".career-position-now-label").attr("for", companyFormName + "_" + companyIndex + "__" + positionFormName + "_" + positionIndex + "__" + positionNowFieldName);
                $(this).find(".career-position-now-input").attr({
                    "id": companyFormName + "_" + companyIndex + "__" + positionFormName + "_" + positionIndex + "__" + positionNowFieldName,
                    "name": companyFormName + "[" + companyIndex + "]." + positionFormName + "[" + positionIndex + "]." + positionNowFieldName
                });

                $(this).find(".position-key-tasks-label").attr("for", companyFormName + "_" + companyIndex + "__" + positionFormName + "_" + positionIndex + "__" + positionKeyTasks);
                $(this).find(".position-key-tasks-input").attr({
                    "id": companyFormName + "_" + companyIndex + "__" + positionFormName + "_" + positionIndex + "__" + positionKeyTasks,
                    "name": companyFormName + "[" + companyIndex + "]." + positionFormName + "[" + positionIndex + "]." + positionKeyTasks
                });
                $(this).find(".position-key-tasks-validation").attr("data-valmsg-for", companyFormName + "[" + companyIndex + "]." + positionFormName + "[" + positionIndex + "]." + positionKeyTasks);

                $(this).find(".position-reporting-to-label").attr("for", companyFormName + "_" + companyIndex + "__" + positionFormName + "_" + positionIndex + "__" + positionReportingToFieldName);
                $(this).find(".position-reporting-to-input").attr({
                    "id": companyFormName + "_" + companyIndex + "__" + positionFormName + "_" + positionIndex + "__" + positionReportingToFieldName,
                    "name": companyFormName + "[" + companyIndex + "]." + positionFormName + "[" + positionIndex + "]." + positionReportingToFieldName
                });
                $(this).find(".position-reporting-to-validation").attr("data-valmsg-for", companyFormName + "[" + companyIndex + "]." + positionFormName + "[" + positionIndex + "]." + positionReportingToFieldName);

                $(this).find(".position-subordinates-label").attr("for", companyFormName + "_" + companyIndex + "__" + positionFormName + "_" + positionIndex + "__" + positionDirectSubordinatesFieldName);
                $(this).find(".position-subordinates-input").attr({
                    "id": companyFormName + "_" + companyIndex + "__" + positionFormName + "_" + positionIndex + "__" + positionDirectSubordinatesFieldName,
                    "name": companyFormName + "[" + companyIndex + "]." + positionFormName + "[" + positionIndex + "]." + positionDirectSubordinatesFieldName
                });
                $(this).find(".position-subordinates-validation").attr("data-valmsg-for", companyFormName + "[" + companyIndex + "]." + positionFormName + "[" + positionIndex + "]." + positionDirectSubordinatesFieldName);

                $(this).find(".position-achievements-label").attr("for", companyFormName + "_" + companyIndex + "__" + positionFormName + "_" + positionIndex + "__" + positionAchievementsFieldName);
                $(this).find(".position-achievements-input").attr({
                    "id": companyFormName + "_" + companyIndex + "__" + positionFormName + "_" + positionIndex + "__" + positionAchievementsFieldName,
                    "name": companyFormName + "[" + companyIndex + "]." + positionFormName + "[" + positionIndex + "]." + positionAchievementsFieldName
                });
                $(this).find(".position-achievements-validation").attr("data-valmsg-for", companyFormName + "[" + companyIndex + "]." + positionFormName + "[" + positionIndex + "]." + positionAchievementsFieldName);

                $(this).find(".position-reason-label").attr("for", companyFormName + "_" + companyIndex + "__" + positionFormName + "_" + positionIndex + "__" + positionReasonForLeavingFieldName);
                $(this).find(".position-reason-input").attr({
                    "id": companyFormName + "_" + companyIndex + "__" + positionFormName + "_" + positionIndex + "__" + positionReasonForLeavingFieldName,
                    "name": companyFormName + "[" + companyIndex + "]." + positionFormName + "[" + positionIndex + "]." + positionReasonForLeavingFieldName
                });
                $(this).find(".position-reason-validation").attr("data-valmsg-for", companyFormName + "[" + companyIndex + "]." + positionFormName + "[" + positionIndex + "]." + positionReasonForLeavingFieldName);

            });
        });

    }
    function removeCompany() {
        $(this).closest('div[class^="company_row"]').remove();

        updateCompanyFieldNumbers();
    }

    $("#career_summary_add").click(function () {
        var existingCompanyRowCount = $(".company_row").length;
        var lastCompanyRow = $(".company_row").last();
        var newRow = lastCompanyRow.clone();

        var companyFormName = "Companies";
        var companyNameFieldName = "Name";
        var companyCityFieldName = "City";
        var companyParentCompanyFieldName = "ParentCompanyName";
        var companyIndustryFieldName = "Industry";
        var companyOtherIndustryFieldName = "OtherIndustry";
        var companyMainProductionsFieldName = "MainProductions";
        var companyTurnoverFieldName = "Turnover";
        var companyEmployeesFieldName = "NumberOfEmployees";
        var positionFormName = "Positions";
        var positionNameFieldName = "Name";
        var positionFromTimeFieldName = "FromTime";
        var positionToTimeFieldName = "ToTime";
        var positionNowFieldName = "Now";
        var positionKeyTasks = "KeyTasks";
        var positionReportingToFieldName = "ReportingTo";
        var positionDirectSubordinatesFieldName = "DirectSubordinates";
        var positionAchievementsFieldName = "Achievements";
        var positionReasonForLeavingFieldName = "ReasonForLeaving";

        newRow.find(".company-name-label").attr("for", companyFormName + "_" + existingCompanyRowCount + "__" + companyNameFieldName);
        newRow.find(".company-name-input").attr({
            "id": companyFormName + "_" + existingCompanyRowCount + "__" + companyNameFieldName,
            "name": companyFormName + "[" + existingCompanyRowCount + "]." + companyNameFieldName,
            "value": null
        });
        newRow.find(".company-name-validation").attr("data-valmsg-for", companyFormName + "[" + existingCompanyRowCount + "]." + companyNameFieldName);

        newRow.find(".company-city-label").attr("for", companyFormName + "_" + existingCompanyRowCount + "__" + companyCityFieldName);
        newRow.find(".company-city-input").attr({
            "id": companyFormName + "_" + existingCompanyRowCount + "__" + companyCityFieldName,
            "name": companyFormName + "[" + existingCompanyRowCount + "]." + companyCityFieldName,
            "value": null
        });
        newRow.find(".company-city-validation").attr("data-valmsg-for", companyFormName + "[" + existingCompanyRowCount + "]." + companyCityFieldName);

        newRow.find(".company-parent-company-label").attr("for", companyFormName + "_" + existingCompanyRowCount + "__" + companyParentCompanyFieldName);
        newRow.find(".company-parent-company-input").attr({
            "id": companyFormName + "_" + existingCompanyRowCount + "__" + companyParentCompanyFieldName,
            "name": companyFormName + "[" + existingCompanyRowCount + "]." + companyParentCompanyFieldName,
            "value": null
        });
        newRow.find(".company-parent-company-validation").attr("data-valmsg-for", companyFormName + "[" + existingCompanyRowCount + "]." + companyParentCompanyFieldName);

        newRow.find(".company-industry-label").attr("for", companyFormName + "_" + existingCompanyRowCount + "__" + companyIndustryFieldName);
        newRow.find(".company-industry-select").attr({
            "id": companyFormName + "_" + existingCompanyRowCount + "__" + companyIndustryFieldName,
            "name": companyFormName + "[" + existingCompanyRowCount + "]." + companyIndustryFieldName
        });
        newRow.find(".company-industry-select option[selected='selected']").removeAttr("selected");
        newRow.find(".company-industry-validation").attr("data-valmsg-for", companyFormName + "[" + existingCompanyRowCount + "]." + companyIndustryFieldName);

        newRow.find(".company-other-industry-label").attr("for", companyFormName + "_" + existingCompanyRowCount + "__" + companyOtherIndustryFieldName);
        newRow.find(".company-other-industry-input").attr({
            "id": companyFormName + "_" + existingCompanyRowCount + "__" + companyOtherIndustryFieldName,
            "name": companyFormName + "[" + existingCompanyRowCount + "]." + companyOtherIndustryFieldName,
            "value": null
        });
        newRow.find(".company-other-industry-validation").attr("data-valmsg-for", companyFormName + "[" + existingCompanyRowCount + "]." + companyOtherIndustryFieldName);

        newRow.find(".company-productions-label").attr("for", companyFormName + "_" + existingCompanyRowCount + "__" + companyMainProductionsFieldName);
        newRow.find(".company-productions-input").attr({
            "id": companyFormName + "_" + existingCompanyRowCount + "__" + companyMainProductionsFieldName,
            "name": companyFormName + "[" + existingCompanyRowCount + "]." + companyMainProductionsFieldName,
            "value": null
        });
        newRow.find(".company-productions-validation").attr("data-valmsg-for", companyFormName + "[" + existingCompanyRowCount + "]." + companyMainProductionsFieldName);

        newRow.find(".company-turnover-label").attr("for", companyFormName + "_" + existingCompanyRowCount + "__" + companyTurnoverFieldName);
        newRow.find(".company-turnover-input").attr({
            "id": companyFormName + "_" + existingCompanyRowCount + "__" + companyTurnoverFieldName,
            "name": companyFormName + "[" + existingCompanyRowCount + "]." + companyTurnoverFieldName,
            "value": null
        });
        newRow.find(".company-turnover-validation").attr("data-valmsg-for", companyFormName + "[" + existingCompanyRowCount + "]." + companyTurnoverFieldName);

        newRow.find(".company-employees-label").attr("for", companyFormName + "_" + existingCompanyRowCount + "__" + companyEmployeesFieldName);
        newRow.find(".company-employees-input").attr({
            "id": companyFormName + "_" + existingCompanyRowCount + "__" + companyEmployeesFieldName,
            "name": companyFormName + "[" + existingCompanyRowCount + "]." + companyEmployeesFieldName,
            "value": null
        });
        newRow.find(".company-employees-validation").attr("data-valmsg-for", companyFormName + "[" + existingCompanyRowCount + "]." + companyEmployeesFieldName);

        newRow.find(".position_row").slice(1).remove();

        newRow.find(".position-name-label").attr("for", companyFormName + "_" + existingCompanyRowCount + "__" + positionFormName + "_0__" + positionNameFieldName);
        newRow.find(".position-name-input").attr({
            "id": companyFormName + "_" + existingCompanyRowCount + "__" + positionFormName + "_0__" + positionNameFieldName,
            "name": companyFormName + "[" + existingCompanyRowCount + "]." + positionFormName + "[0]." + positionNameFieldName,
            "value": null
        });
        newRow.find(".position-name-validation").attr("data-valmsg-for", companyFormName + "[" + existingCompanyRowCount + "]." + positionFormName + "[0]." + positionNameFieldName);

        newRow.find(".position-from-time-label").attr("for", companyFormName + "_" + existingCompanyRowCount + "__" + positionFormName + "_0__" + positionFromTimeFieldName);
        newRow.find(".position-from-time-input").attr({
            "id": companyFormName + "_" + existingCompanyRowCount + "__" + positionFormName + "_0__" + positionFromTimeFieldName,
            "name": companyFormName + "[" + existingCompanyRowCount + "]." + positionFormName + "[0]." + positionFromTimeFieldName,
            "value": null
        });
        newRow.find(".position-from-time-validation").attr("data-valmsg-for", companyFormName + "[" + existingCompanyRowCount + "]." + positionFormName + "[0]." + positionFromTimeFieldName);

        newRow.find(".position-to-time-label").attr("for", companyFormName + "_" + existingCompanyRowCount + "__" + positionFormName + "_0__" + positionToTimeFieldName);
        newRow.find(".position-to-time-input").attr({
            "id": companyFormName + "_" + existingCompanyRowCount + "__" + positionFormName + "_0__" + positionToTimeFieldName,
            "name": companyFormName + "[" + existingCompanyRowCount + "]." + positionFormName + "[0]." + positionToTimeFieldName,
            "value": null
        });
        newRow.find(".position-to-time-validation").attr("data-valmsg-for", companyFormName + "[" + existingCompanyRowCount + "]." + positionFormName + "[0]." + positionToTimeFieldName);

        newRow.find(".career-position-now-label").attr("for", companyFormName + "_" + existingCompanyRowCount + "__" + positionFormName + "_0__" + positionNowFieldName);
        newRow.find(".career-position-now-input").attr({
            "id": companyFormName + "_" + existingCompanyRowCount + "__" + positionFormName + "_0__" + positionNowFieldName,
            "name": companyFormName + "[" + existingCompanyRowCount + "]." + positionFormName + "[0]." + positionNowFieldName,
            "value": null
        });

        newRow.find(".position-key-tasks-label").attr("for", companyFormName + "_" + existingCompanyRowCount + "__" + positionFormName + "_0__" + positionKeyTasks);
        newRow.find(".position-key-tasks-input").attr({
            "id": companyFormName + "_" + existingCompanyRowCount + "__" + positionFormName + "_0__" + positionKeyTasks,
            "name": companyFormName + "[" + existingCompanyRowCount + "]." + positionFormName + "[0]." + positionKeyTasks
        });
        newRow.find(".position-key-tasks-input").val(null);
        newRow.find(".position-key-tasks-validation").attr("data-valmsg-for", companyFormName + "[" + existingCompanyRowCount + "]." + positionFormName + "[0]." + positionKeyTasks);

        newRow.find(".position-reporting-to-label").attr("for", companyFormName + "_" + existingCompanyRowCount + "__" + positionFormName + "_0__" + positionReportingToFieldName);
        newRow.find(".position-reporting-to-input").attr({
            "id": companyFormName + "_" + existingCompanyRowCount + "__" + positionFormName + "_0__" + positionReportingToFieldName,
            "name": companyFormName + "[" + existingCompanyRowCount + "]." + positionFormName + "[0]." + positionReportingToFieldName,
            "value": null
        });
        newRow.find(".position-reporting-to-validation").attr("data-valmsg-for", companyFormName + "[" + existingCompanyRowCount + "]." + positionFormName + "[0]." + positionReportingToFieldName);

        newRow.find(".position-subordinates-label").attr("for", companyFormName + "_" + existingCompanyRowCount + "__" + positionFormName + "_0__" + positionDirectSubordinatesFieldName);
        newRow.find(".position-subordinates-input").attr({
            "id": companyFormName + "_" + existingCompanyRowCount + "__" + positionFormName + "_0__" + positionDirectSubordinatesFieldName,
            "name": companyFormName + "[" + existingCompanyRowCount + "]." + positionFormName + "[0]." + positionDirectSubordinatesFieldName
        });
        newRow.find(".position-subordinates-input").val(null);
        newRow.find(".position-subordinates-validation").attr("data-valmsg-for", companyFormName + "[" + existingCompanyRowCount + "]." + positionFormName + "[0]." + positionDirectSubordinatesFieldName);

        newRow.find(".position-achievements-label").attr("for", companyFormName + "_" + existingCompanyRowCount + "__" + positionFormName + "_0__" + positionAchievementsFieldName);
        newRow.find(".position-achievements-input").attr({
            "id": companyFormName + "_" + existingCompanyRowCount + "__" + positionFormName + "_0__" + positionAchievementsFieldName,
            "name": companyFormName + "[" + existingCompanyRowCount + "]." + positionFormName + "[0]." + positionAchievementsFieldName
        });
        newRow.find(".position-achievements-input").val(null);
        newRow.find(".position-achievements-validation").attr("data-valmsg-for", companyFormName + "[" + existingCompanyRowCount + "]." + positionFormName + "[0]." + positionAchievementsFieldName);

        newRow.find(".position-reason-label").attr("for", companyFormName + "_" + existingCompanyRowCount + "__" + positionFormName + "_0__" + positionReasonForLeavingFieldName);
        newRow.find(".position-reason-input").attr({
            "id": companyFormName + "_" + existingCompanyRowCount + "__" + positionFormName + "_0__" + positionReasonForLeavingFieldName,
            "name": companyFormName + "[" + existingCompanyRowCount + "]." + positionFormName + "[0]." + positionReasonForLeavingFieldName
        });
        newRow.find(".position-reason-input").val(null);
        newRow.find(".position-reason-validation").attr("data-valmsg-for", companyFormName + "[" + existingCompanyRowCount + "]." + positionFormName + "[0]." + positionReasonForLeavingFieldName);

        newRow.find(".company-remove").click(removeCompany);
        newRow.find(".position-remove").click(removePosition);
        newRow.find(".position_add").click(addPosition);

        $("#companies_container").append(newRow);
    });

    $(".company-remove").click(removeCompany);

    function removePosition() {
        $(this).closest('div[class^="position_row"]').remove();

        updateCompanyFieldNumbers();
    }

    function addPosition() {
        var lastPositionRow = $(".position_row").last();
        var newRow = lastPositionRow.clone();

        var currentNumber = parseInt(newRow.find(".position-number").text());

        newRow.find(".position-number").text(currentNumber + 1);

        newRow.find(".position-name-input").attr({
            "value": null
        });

        newRow.find(".position-from-time-input").attr({
            "value": null
        });

        newRow.find(".position-to-time-input").attr({
            "value": null
        });

        newRow.find(".career-position-now-input").attr({
            "value": null
        });
        
        newRow.find(".position-key-tasks-input").val(null);
        
        newRow.find(".position-reporting-to-input").attr({
            "value": null
        });

        newRow.find(".position-subordinates-input").val(null);

        newRow.find(".position-achievements-input").val(null);

        newRow.find(".position-reason-input").val(null);

        newRow.find(".position-remove").click(removePosition);
        $(this).closest('div[class^="company_row"]').find(".positions_container").append(newRow);

        updateCompanyFieldNumbers();
    }

    $(".position_add").click(addPosition);

    $(".position-remove").click(removePosition);
});