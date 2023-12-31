﻿using Microsoft.JSInterop;
using System;
using System.Threading;
using System.Threading.Tasks;
using Core.Interfaces;

namespace Core.Helpers
{
    public class LocalStorage : ILocalStorage
    {
        private readonly IJSRuntime _jSRuntime;
        private readonly IJSInProcessRuntime _jSInProcessRuntime;

        public LocalStorage(IJSRuntime jSRuntime)
        {
            _jSRuntime = jSRuntime;
            _jSInProcessRuntime = jSRuntime as IJSInProcessRuntime;
        }

        public ValueTask ClearAsync(CancellationToken? cancellationToken = null)
            => _jSRuntime.InvokeVoidAsync("localStorage.clear", cancellationToken ?? CancellationToken.None);

        public ValueTask<string> GetItemAsync(string key, CancellationToken? cancellationToken = null)
            => _jSRuntime.InvokeAsync<string>("localStorage.getItem", cancellationToken ?? CancellationToken.None, key);

        public ValueTask<string> KeyAsync(int index, CancellationToken? cancellationToken = null)
            => _jSRuntime.InvokeAsync<string>("localStorage.key", cancellationToken ?? CancellationToken.None, index);

        public ValueTask<bool> ContainKeyAsync(string key, CancellationToken? cancellationToken = null)
            => _jSRuntime.InvokeAsync<bool>("localStorage.hasOwnProperty", cancellationToken ?? CancellationToken.None, key);

        public ValueTask<int> LengthAsync(CancellationToken? cancellationToken = null)
            => _jSRuntime.InvokeAsync<int>("eval", cancellationToken ?? CancellationToken.None, "localStorage.length");

        public ValueTask RemoveItemAsync(string key, CancellationToken? cancellationToken = null)
            => _jSRuntime.InvokeVoidAsync("localStorage.removeItem", cancellationToken ?? CancellationToken.None, key);

        public ValueTask SetItemAsync(string key, string data, CancellationToken? cancellationToken = null)
            => _jSRuntime.InvokeVoidAsync("localStorage.setItem", cancellationToken ?? CancellationToken.None, key, data);

        public void Clear()
        {
            CheckForInProcessRuntime();
            _jSInProcessRuntime.InvokeVoid("localStorage.clear");
        }

        public string GetItem(string key)
        {
            CheckForInProcessRuntime();
            return _jSInProcessRuntime.Invoke<string>("localStorage.getItem", key);
        }

        public string Key(int index)
        {
            CheckForInProcessRuntime();
            return _jSInProcessRuntime.Invoke<string>("localStorage.key", index);
        }

        public bool ContainKey(string key)
        {
            CheckForInProcessRuntime();
            return _jSInProcessRuntime.Invoke<bool>("localStorage.hasOwnProperty", key);
        }

        public int Length()
        {
            CheckForInProcessRuntime();
            return _jSInProcessRuntime.Invoke<int>("eval", "localStorage.length");
        }

        public void RemoveItem(string key)
        {
            CheckForInProcessRuntime();
            _jSInProcessRuntime.InvokeVoidAsync("localStorage.removeItem", key);
        }

        public void SetItem(string key, string data)
        {
            CheckForInProcessRuntime();
            _jSInProcessRuntime.InvokeVoid("localStorage.setItem", key, data);
        }

        private void CheckForInProcessRuntime()
        {
            if (_jSInProcessRuntime == null)
                throw new InvalidOperationException("IJSInProcessRuntime not available");
        }
    }
}
