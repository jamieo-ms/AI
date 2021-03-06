﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license.

using System;
using System.Collections.Generic;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Graph;

namespace CalendarSkill
{
    /// <summary>
    /// The state of calendar skill.
    /// </summary>
    public class CalendarSkillState
    {
        public const int PageSize = 5;

        /// <summary>
        /// Initializes a new instance of the <see cref="CalendarSkillState"/> class.
        /// </summary>
        public CalendarSkillState()
        {
            User = new User();
            UserInfo = null;
            Title = null;
            Content = null;
            StartDate = null;
            StartTime = null;
            StartDateTime = null;
            EndDateTime = null;
            Location = null;
            Attendees = new List<EventModel.Attendee>();
            APIToken = null;
            Events = new List<EventModel>();
            NewStartDateTime = null;
            EventSource = EventSource.Microsoft;
            AttendeesNameList = new List<string>();
            ConfirmAttendeesNameIndex = 0;
            DialogName = string.Empty;
            ShowAttendeesIndex = 0;
            ShowEventIndex = 0;
            SummaryEvents = null;
            ReadOutEvents = new List<EventModel>();
        }

        public User User { get; set; }

        public UserInformation UserInfo { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? StartTime { get; set; }

        public DateTime? StartDateTime { get; set; }

        public DateTime? EndDateTime { get; set; }

        public string Location { get; set; }

        public List<EventModel.Attendee> Attendees { get; set; }

        public string APIToken { get; set; }

        public List<EventModel> Events { get; set; }

        public object NewStartDateTime { get; set; }

        public EventSource EventSource { get; set; }

        public List<string> AttendeesNameList { get; set; }

        public int ConfirmAttendeesNameIndex { get; set; }

        public string DialogName { get; set; }

        public int ShowAttendeesIndex { get; set; }

        public IRecognizerConvert LuisResultPassedFromSkill { get; set; }

        public DialogState ConversationDialogState { get; set; }

        public int ShowEventIndex { get; set; }

        public List<EventModel> SummaryEvents { get; set; }

        public List<EventModel> ReadOutEvents { get; set; }

        public TimeZoneInfo GetUserTimeZone()
        {
            if ((UserInfo != null) && (UserInfo.Timezone != null))
            {
                return UserInfo.Timezone;
            }

            return TimeZoneInfo.Local;
        }

        public void Clear()
        {
            User = new User();
            UserInfo = null;
            Title = null;
            Content = null;
            StartDate = null;
            StartTime = null;
            StartDateTime = null;
            EndDateTime = null;
            Location = null;
            Attendees = new List<EventModel.Attendee>();
            APIToken = null;
            Events = new List<EventModel>();
            NewStartDateTime = null;
            EventSource = EventSource.Microsoft;
            AttendeesNameList = new List<string>();
            ConfirmAttendeesNameIndex = 0;
            DialogName = string.Empty;
            ShowAttendeesIndex = 0;
            ShowEventIndex = 0;
            SummaryEvents = null;
            ReadOutEvents = new List<EventModel>();
        }

        public class UserInformation
        {
            public string Name { get; set; }

            public TimeZoneInfo Timezone { get; set; }

            public double Latitude { get; set; }

            public double Longitude { get; set; }
        }
    }
}
