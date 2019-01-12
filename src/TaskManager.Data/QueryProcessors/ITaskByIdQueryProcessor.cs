﻿using TaskManager.Data.Entities;

namespace TaskManager.Data.QueryProcessors
{
    public interface ITaskByIdQueryProcessor
    {
        Task GetTaskById(long id);
    }
}