﻿namespace FileStore
{
    public interface IStore
    {
        public Maybe<string> ReadAllext(int id);
        public void Save(int id, string message);
    }
}