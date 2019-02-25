$(document).ready(function () {

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

        $(".education_row").each(function (index) {

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
});