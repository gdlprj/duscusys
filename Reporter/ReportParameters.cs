﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Discussions.DbModel;

namespace Reporter
{
    public class ReportParameters    
    {
        public List<int> requiredUsers;
        public Session session;
        public Topic topic;

        public ReportParameters(List<int> requiredUsers, Session session, Topic topic)
        {
            this.requiredUsers = requiredUsers;
            this.session = session;
            this.topic = topic;
        }
    }
}