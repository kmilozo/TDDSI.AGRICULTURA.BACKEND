﻿namespace TDDSI.AGRICULTURA.BACKEND.Domain.Abstractions;
public interface IEntityBase<T> {
    T Id { get; init; }
}
