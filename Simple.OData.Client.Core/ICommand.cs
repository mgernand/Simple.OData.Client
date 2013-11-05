﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Simple.OData.Client
{
    public interface ICommand
    {
        IClientWithCommand For(string collectionName);
        IClientWithCommand For<T>();
        IClientWithCommand As(string derivedCollectionName);
        IClientWithCommand As<T>();
        IClientWithCommand Key(params object[] entryKey);
        IClientWithCommand Key(IEnumerable<object> entryKey);
        IClientWithCommand Key(IDictionary<string, object> entryKey);
        IClientWithCommand Filter(string filter);
        IClientWithCommand Filter(FilterExpression expression);
        IClientWithCommand Filter<T>(Expression<Func<T, bool>> expression);
        IClientWithCommand Skip(int count);
        IClientWithCommand Top(int count);
        IClientWithCommand Expand(IEnumerable<string> associations);
        IClientWithCommand Expand(params string[] associations);
        IClientWithCommand Expand<T>(Expression<Func<T, object>> expression);
        IClientWithCommand Select(IEnumerable<string> columns);
        IClientWithCommand Select(params string[] columns);
        IClientWithCommand Select<T>(Expression<Func<T, object>> expression);
        IClientWithCommand OrderBy(IEnumerable<KeyValuePair<string, bool>> columns);
        IClientWithCommand OrderBy(params string[] columns);
        IClientWithCommand OrderBy<T>(Expression<Func<T, object>> expression);
        IClientWithCommand OrderByDescending(params string[] columns);
        IClientWithCommand OrderByDescending<T>(Expression<Func<T, object>> expression);
        IClientWithCommand Count();
        IClientWithCommand NavigateTo(string linkName);
        IClientWithCommand NavigateTo<T>();
        IClientWithCommand Set(object value);
        IClientWithCommand Set(IDictionary<string, object> value);
        IClientWithCommand Function(string functionName);
        IClientWithCommand Parameters(IDictionary<string, object> parameters);
        bool FilterIsKey { get; }
        IDictionary<string, object> FilterAsKey { get; }
    }
}