/*
* Code on Page adapted from:
* Password Hashing With PBKDF2 (http://crackstation.net/hashing-security.htm).
* Copyright (c) 2013, Taylor Hornby
* All rights reserved.
* Redistribution and use in source and binary forms, with or without modification, are permitted provided that the following conditions are met:
* 1. Redistributions of source code must retain the above copyright notice, this list of conditions and the following disclaimer.
* 2. Redistributions in binary form must reproduce the above copyright notice, this list of conditions and the following disclaimer in the documentation and/or other materials provided with the distribution.
* THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
*/
using System;
using System.Text;
using System.Security.Cryptography;

namespace VacationLib
{
    public static class PasswordHash
    {
        //can be changed w/out breaking existing hashes
        private const int SaltSize = 24;
        private const int HashSize = 24;
        private const int PBKF2Iterations = 1000;
        private const int IterationIndex = 1;
        private const int SaltIndex = 2;
        private const int PBKDF2Index = 3;

        public static string CreateHash(string password)
        {
            RNGCryptoServiceProvider cryptoService = new RNGCryptoServiceProvider();
            byte[] salt = new byte[SaltSize];
            cryptoService.GetBytes(salt);
            byte[] hash = PBKDF2(password, salt, PBKF2Iterations, HashSize);
            //index values must shift down one if getting rid of explicit sha1
            return "sha1:" + PBKF2Iterations + ":" + Convert.ToBase64String(salt) + ":" + Convert.ToBase64String(hash);
        }

        public static bool ValidatePassword(string password, string goodHash)
        {
            char[] delimiter = { ':' };
            string[] split = goodHash.Split(delimiter);
            int iterations = int.Parse(split[IterationIndex]);
            byte[] salt = Convert.FromBase64String(split[SaltIndex]);
            byte[] hash = Convert.FromBase64String(split[PBKDF2Index]);
            byte[] testHash = PBKDF2(password, salt, iterations, hash.Length);
            return SlowEquals(hash, testHash);
        }

        private static bool SlowEquals(byte[] a, byte[] b)
        {
            uint diff = (uint)a.Length ^ (uint)b.Length;
            for (int i = 0; i < a.Length && i < b.Length; i++)
                diff |= (uint)(a[i] ^ b[i]);
            bool isEqual = (diff == 0);
            return isEqual;
        }

        private static byte[] PBKDF2(string password, byte[] salt, int iterations, int outputBytes)
        {
            Rfc2898DeriveBytes pbkdf2 = new Rfc2898DeriveBytes(password, salt);
            pbkdf2.IterationCount = iterations;
            return pbkdf2.GetBytes(outputBytes);
        }
    }
}
