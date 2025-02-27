﻿// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE AS LONG AS SOFTWARE FUNDS ARE DONATED TO THE POOR
// ---------------------------------------------------------------

using System;

namespace OtripleS.Web.Api.Models.Exams.Exceptions
{
    public class LockedExamException : Exception
    {
        public LockedExamException(Exception innerException)
            : base(message: "Locked exam record exception, please try again later.", innerException) { }
    }
}
