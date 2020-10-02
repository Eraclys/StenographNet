﻿using StenographNet.Common;

namespace StenographNet
{
    public static class StenographExtensions
    {
        public static void Embed<T>(this Stenograph<T> stenograph, BitReader bitReader) where T : class
        {
            stenograph.Strategy.Embed(stenograph.Value, bitReader);
        }

        public static void Extract<T>(this Stenograph<T> stenograph, BitWriter bitWriter) where T : class
        {
            stenograph.Strategy.Extract(stenograph.Value, bitWriter);
        }

        public static void EmbedMessage<T>(this Stenograph<T> stenograph, string message) where T : class
        {
            stenograph.Strategy.EmbedMessage(stenograph.Value, message);
        }

        public static string ExtractMessage<T>(this Stenograph<T> stenograph) where T : class
        {
            return stenograph.Strategy.ExtractMessage(stenograph.Value);
        }
    }
}