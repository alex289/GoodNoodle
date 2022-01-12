﻿using System;
using static GoodNoodle.Domain.Enums;

namespace GoodNoodle.Application.ViewModel.UserInGroup;

public class UserInGroupViewModel
{
    public Guid Id { get; set; }
    public Guid NoodleGroupId { get; set; }
    public Guid NoodleUserId { get; set; }
    public GroupRole Role { get; set; }
}
