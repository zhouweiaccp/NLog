using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JetBrains.Annotations;
using System.Runtime.CompilerServices;

namespace NLog
{
    /// <summary>
    /// Ilogger with caller attributes
    /// </summary>
    [CLSCompliant(false)]
    public partial interface ILogger2 : ILogger
    {
#if !NET4_0 && !NET3_5
        #region Trace() overloads 

        /// <overloads>
        /// Writes the diagnostic message at the <c>Trace</c> level using the specified format provider and format parameters.
        /// </overloads>
        /// <summary>
        /// Writes the diagnostic message at the <c>Trace</c> level.
        /// </summary>
        /// <param name="memberName"></param>
        /// <param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="T">Type of the value.</typeparam>
        /// <param name="value">The value to be written.</param>
        /// 
        /// 
        void Trace<T>(T value, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Trace</c> level.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="T">Type of the value.</typeparam>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="value">The value to be written.</param>
        void Trace<T>(IFormatProvider formatProvider, T value, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Trace</c> level.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <param name="messageFunc">A function returning message to be written. Function is not evaluated if logging is not enabled.</param>
        void Trace(LogMessageGenerator messageFunc, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message and exception at the <c>Trace</c> level.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <param name="message">A <see langword="string" /> to be written.</param>
        /// <param name="exception">An exception to be logged.</param>
        /// <param name="args">Arguments to format.</param>
        [StringFormatMethod("message")]
        void Trace(Exception exception, [Localizable(false)] string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0, params object[] args);

        /// <summary>
        /// Writes the diagnostic message and exception at the <c>Trace</c> level.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A <see langword="string" /> to be written.</param>
        /// <param name="exception">An exception to be logged.</param>
        /// <param name="args">Arguments to format.</param>
        [StringFormatMethod("message")]
        void Trace(Exception exception, IFormatProvider formatProvider, [Localizable(false)] string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0, params object[] args);

        /// <summary>
        /// Writes the diagnostic message at the <c>Trace</c> level using the specified parameters and formatting them with the supplied format provider.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A <see langword="string" /> containing format items.</param>
        /// <param name="args">Arguments to format.</param>
        [StringFormatMethod("message")]
        void Trace(IFormatProvider formatProvider, [Localizable(false)] string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0, params object[] args);

        /// <summary>
        /// Writes the diagnostic message at the <c>Trace</c> level.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <param name="message">Log message.</param>
        void Trace([Localizable(false)] string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Trace</c> level using the specified parameters.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <param name="message">A <see langword="string" /> containing format items.</param>
        /// <param name="args">Arguments to format.</param>
        [StringFormatMethod("message")]
        void Trace([Localizable(false)] string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0, params object[] args);


        /// <summary>
        /// Writes the diagnostic message at the <c>Trace</c> level using the specified parameter and formatting it with the supplied format provider.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="TArgument">The type of the argument.</typeparam>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A <see langword="string" /> containing one format item.</param>
        /// <param name="argument">The argument to format.</param>
        [StringFormatMethod("message")]
        void Trace<TArgument>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument argument, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Trace</c> level using the specified parameter.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="TArgument">The type of the argument.</typeparam>
        /// <param name="message">A <see langword="string" /> containing one format item.</param>
        /// <param name="argument">The argument to format.</param>
        [StringFormatMethod("message")]
        void Trace<TArgument>([Localizable(false)] string message, TArgument argument, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Trace</c> level using the specified arguments formatting it with the supplied format provider.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A <see langword="string" /> containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        [StringFormatMethod("message")]
        void Trace<TArgument1, TArgument2>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Trace</c> level using the specified parameters.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <param name="message">A <see langword="string" /> containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        [StringFormatMethod("message")]
        void Trace<TArgument1, TArgument2>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Trace</c> level using the specified arguments formatting it with the supplied format provider.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <typeparam name="TArgument3">The type of the third argument.</typeparam>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A <see langword="string" /> containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        /// <param name="argument3">The third argument to format.</param>
        [StringFormatMethod("message")]
        void Trace<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Trace</c> level using the specified parameters.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <typeparam name="TArgument3">The type of the third argument.</typeparam>
        /// <param name="message">A <see langword="string" /> containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        /// <param name="argument3">The third argument to format.</param>
        [StringFormatMethod("message")]
        void Trace<TArgument1, TArgument2, TArgument3>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        #endregion

        #region Debug() overloads 

        /// <overloads>
        /// Writes the diagnostic message at the <c>Debug</c> level using the specified format provider and format parameters.
        /// </overloads>
        /// <summary>
        /// Writes the diagnostic message at the <c>Debug</c> level.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="T">Type of the value.</typeparam>
        /// <param name="value">The value to be written.</param>
        void Debug<T>(T value, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Debug</c> level.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="T">Type of the value.</typeparam>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="value">The value to be written.</param>
        void Debug<T>(IFormatProvider formatProvider, T value, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Debug</c> level.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <param name="messageFunc">A function returning message to be written. Function is not evaluated if logging is not enabled.</param>
        void Debug(LogMessageGenerator messageFunc, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message and exception at the <c>Debug</c> level.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <param name="message">A <see langword="string" /> to be written.</param>
        /// <param name="exception">An exception to be logged.</param>
        /// <param name="args">Arguments to format.</param>
        [StringFormatMethod("message")]
        void Debug(Exception exception, [Localizable(false)] string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0, params object[] args);

        /// <summary>
        /// Writes the diagnostic message and exception at the <c>Debug</c> level.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A <see langword="string" /> to be written.</param>
        /// <param name="exception">An exception to be logged.</param>
        /// <param name="args">Arguments to format.</param>
        [StringFormatMethod("message")]
        void Debug(Exception exception, IFormatProvider formatProvider, [Localizable(false)] string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0, params object[] args);

        /// <summary>
        /// Writes the diagnostic message at the <c>Debug</c> level using the specified parameters and formatting them with the supplied format provider.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A <see langword="string" /> containing format items.</param>
        /// <param name="args">Arguments to format.</param>
        [StringFormatMethod("message")]
        void Debug(IFormatProvider formatProvider, [Localizable(false)] string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0, params object[] args);

        /// <summary>
        /// Writes the diagnostic message at the <c>Debug</c> level.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <param name="message">Log message.</param>
        void Debug([Localizable(false)] string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Debug</c> level using the specified parameters.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <param name="message">A <see langword="string" /> containing format items.</param>
        /// <param name="args">Arguments to format.</param>
        [StringFormatMethod("message")]
        void Debug([Localizable(false)] string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0, params object[] args);

        /// <summary>
        /// Writes the diagnostic message at the <c>Debug</c> level using the specified parameter and formatting it with the supplied format provider.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="TArgument">The type of the argument.</typeparam>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A <see langword="string" /> containing one format item.</param>
        /// <param name="argument">The argument to format.</param>
        [StringFormatMethod("message")]
        void Debug<TArgument>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument argument, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Debug</c> level using the specified parameter.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="TArgument">The type of the argument.</typeparam>
        /// <param name="message">A <see langword="string" /> containing one format item.</param>
        /// <param name="argument">The argument to format.</param>
        [StringFormatMethod("message")]
        void Debug<TArgument>([Localizable(false)] string message, TArgument argument, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Debug</c> level using the specified arguments formatting it with the supplied format provider.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A <see langword="string" /> containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        [StringFormatMethod("message")]
        void Debug<TArgument1, TArgument2>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Debug</c> level using the specified parameters.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <param name="message">A <see langword="string" /> containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        [StringFormatMethod("message")]
        void Debug<TArgument1, TArgument2>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Debug</c> level using the specified arguments formatting it with the supplied format provider.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <typeparam name="TArgument3">The type of the third argument.</typeparam>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A <see langword="string" /> containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        /// <param name="argument3">The third argument to format.</param>
        [StringFormatMethod("message")]
        void Debug<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Debug</c> level using the specified parameters.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <typeparam name="TArgument3">The type of the third argument.</typeparam>
        /// <param name="message">A <see langword="string" /> containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        /// <param name="argument3">The third argument to format.</param>
        [StringFormatMethod("message")]
        void Debug<TArgument1, TArgument2, TArgument3>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        #endregion

        #region Info() overloads 

        /// <overloads>
        /// Writes the diagnostic message at the <c>Info</c> level using the specified format provider and format parameters.
        /// </overloads>
        /// <summary>
        /// Writes the diagnostic message at the <c>Info</c> level.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="T">Type of the value.</typeparam>
        /// <param name="value">The value to be written.</param>
        void Info<T>(T value, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Info</c> level.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="T">Type of the value.</typeparam>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="value">The value to be written.</param>
        void Info<T>(IFormatProvider formatProvider, T value, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Info</c> level.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <param name="messageFunc">A function returning message to be written. Function is not evaluated if logging is not enabled.</param>
        void Info(LogMessageGenerator messageFunc, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message and exception at the <c>Info</c> level.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <param name="message">A <see langword="string" /> to be written.</param>
        /// <param name="exception">An exception to be logged.</param>
        /// <param name="args">Arguments to format.</param>
        [StringFormatMethod("message")]
        void Info(Exception exception, [Localizable(false)] string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0, params object[] args);

        /// <summary>
        /// Writes the diagnostic message and exception at the <c>Info</c> level.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A <see langword="string" /> to be written.</param>
        /// <param name="exception">An exception to be logged.</param>
        /// <param name="args">Arguments to format.</param>
        [StringFormatMethod("message")]
        void Info(Exception exception, IFormatProvider formatProvider, [Localizable(false)] string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0, params object[] args);

        /// <summary>
        /// Writes the diagnostic message at the <c>Info</c> level using the specified parameters and formatting them with the supplied format provider.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A <see langword="string" /> containing format items.</param>
        /// <param name="args">Arguments to format.</param>
        [StringFormatMethod("message")]
        void Info(IFormatProvider formatProvider, [Localizable(false)] string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0, params object[] args);

        /// <summary>
        /// Writes the diagnostic message at the <c>Info</c> level.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <param name="message">Log message.</param>
        void Info([Localizable(false)] string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Info</c> level using the specified parameters.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <param name="message">A <see langword="string" /> containing format items.</param>
        /// <param name="args">Arguments to format.</param>
        [StringFormatMethod("message")]
        void Info([Localizable(false)] string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0, params object[] args);

        /// <summary>
        /// Writes the diagnostic message at the <c>Info</c> level using the specified parameter and formatting it with the supplied format provider.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="TArgument">The type of the argument.</typeparam>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A <see langword="string" /> containing one format item.</param>
        /// <param name="argument">The argument to format.</param>
        [StringFormatMethod("message")]
        void Info<TArgument>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument argument, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Info</c> level using the specified parameter.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="TArgument">The type of the argument.</typeparam>
        /// <param name="message">A <see langword="string" /> containing one format item.</param>
        /// <param name="argument">The argument to format.</param>
        [StringFormatMethod("message")]
        void Info<TArgument>([Localizable(false)] string message, TArgument argument, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Info</c> level using the specified arguments formatting it with the supplied format provider.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A <see langword="string" /> containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        [StringFormatMethod("message")]
        void Info<TArgument1, TArgument2>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Info</c> level using the specified parameters.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <param name="message">A <see langword="string" /> containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        [StringFormatMethod("message")]
        void Info<TArgument1, TArgument2>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Info</c> level using the specified arguments formatting it with the supplied format provider.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <typeparam name="TArgument3">The type of the third argument.</typeparam>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A <see langword="string" /> containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        /// <param name="argument3">The third argument to format.</param>
        [StringFormatMethod("message")]
        void Info<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Info</c> level using the specified parameters.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <typeparam name="TArgument3">The type of the third argument.</typeparam>
        /// <param name="message">A <see langword="string" /> containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        /// <param name="argument3">The third argument to format.</param>
        [StringFormatMethod("message")]
        void Info<TArgument1, TArgument2, TArgument3>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        #endregion

        #region Warn() overloads 

        /// <overloads>
        /// Writes the diagnostic message at the <c>Warn</c> level using the specified format provider and format parameters.
        /// </overloads>
        /// <summary>
        /// Writes the diagnostic message at the <c>Warn</c> level.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="T">Type of the value.</typeparam>
        /// <param name="value">The value to be written.</param>
        void Warn<T>(T value, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Warn</c> level.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="T">Type of the value.</typeparam>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="value">The value to be written.</param>
        void Warn<T>(IFormatProvider formatProvider, T value, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Warn</c> level.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <param name="messageFunc">A function returning message to be written. Function is not evaluated if logging is not enabled.</param>
        void Warn(LogMessageGenerator messageFunc, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message and exception at the <c>Warn</c> level.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <param name="message">A <see langword="string" /> to be written.</param>
        /// <param name="exception">An exception to be logged.</param>
        /// <param name="args">Arguments to format.</param>
        [StringFormatMethod("message")]
        void Warn(Exception exception, [Localizable(false)] string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0, params object[] args);

        /// <summary>
        /// Writes the diagnostic message and exception at the <c>Warn</c> level.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A <see langword="string" /> to be written.</param>
        /// <param name="exception">An exception to be logged.</param>
        /// <param name="args">Arguments to format.</param>
        [StringFormatMethod("message")]
        void Warn(Exception exception, IFormatProvider formatProvider, [Localizable(false)] string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0, params object[] args);

        /// <summary>
        /// Writes the diagnostic message at the <c>Warn</c> level using the specified parameters and formatting them with the supplied format provider.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A <see langword="string" /> containing format items.</param>
        /// <param name="args">Arguments to format.</param>
        [StringFormatMethod("message")]
        void Warn(IFormatProvider formatProvider, [Localizable(false)] string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0, params object[] args);

        /// <summary>
        /// Writes the diagnostic message at the <c>Warn</c> level.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <param name="message">Log message.</param>
        void Warn([Localizable(false)] string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Warn</c> level using the specified parameters.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <param name="message">A <see langword="string" /> containing format items.</param>
        /// <param name="args">Arguments to format.</param>
        [StringFormatMethod("message")]
        void Warn([Localizable(false)] string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0, params object[] args);

        /// <summary>
        /// Writes the diagnostic message at the <c>Warn</c> level using the specified parameter and formatting it with the supplied format provider.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="TArgument">The type of the argument.</typeparam>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A <see langword="string" /> containing one format item.</param>
        /// <param name="argument">The argument to format.</param>
        [StringFormatMethod("message")]
        void Warn<TArgument>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument argument, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Warn</c> level using the specified parameter.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="TArgument">The type of the argument.</typeparam>
        /// <param name="message">A <see langword="string" /> containing one format item.</param>
        /// <param name="argument">The argument to format.</param>
        [StringFormatMethod("message")]
        void Warn<TArgument>([Localizable(false)] string message, TArgument argument, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Warn</c> level using the specified arguments formatting it with the supplied format provider.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A <see langword="string" /> containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        [StringFormatMethod("message")]
        void Warn<TArgument1, TArgument2>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Warn</c> level using the specified parameters.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <param name="message">A <see langword="string" /> containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        [StringFormatMethod("message")]
        void Warn<TArgument1, TArgument2>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Warn</c> level using the specified arguments formatting it with the supplied format provider.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <typeparam name="TArgument3">The type of the third argument.</typeparam>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A <see langword="string" /> containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        /// <param name="argument3">The third argument to format.</param>
        [StringFormatMethod("message")]
        void Warn<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Warn</c> level using the specified parameters.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <typeparam name="TArgument3">The type of the third argument.</typeparam>
        /// <param name="message">A <see langword="string" /> containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        /// <param name="argument3">The third argument to format.</param>
        [StringFormatMethod("message")]
        void Warn<TArgument1, TArgument2, TArgument3>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        #endregion

        #region Error() overloads 

        /// <overloads>
        /// Writes the diagnostic message at the <c>Error</c> level using the specified format provider and format parameters.
        /// </overloads>
        /// <summary>
        /// Writes the diagnostic message at the <c>Error</c> level.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="T">Type of the value.</typeparam>
        /// <param name="value">The value to be written.</param>
        void Error<T>(T value, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Error</c> level.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="T">Type of the value.</typeparam>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="value">The value to be written.</param>
        void Error<T>(IFormatProvider formatProvider, T value, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Error</c> level.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <param name="messageFunc">A function returning message to be written. Function is not evaluated if logging is not enabled.</param>
        void Error(LogMessageGenerator messageFunc, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message and exception at the <c>Error</c> level.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <param name="message">A <see langword="string" /> to be written.</param>
        /// <param name="exception">An exception to be logged.</param>
        /// <param name="args">Arguments to format.</param>
        [StringFormatMethod("message")]
        void Error(Exception exception, [Localizable(false)] string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0, params object[] args);

        /// <summary>
        /// Writes the diagnostic message and exception at the <c>Error</c> level.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A <see langword="string" /> to be written.</param>
        /// <param name="exception">An exception to be logged.</param>
        /// <param name="args">Arguments to format.</param>
        [StringFormatMethod("message")]
        void Error(Exception exception, IFormatProvider formatProvider, [Localizable(false)] string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0, params object[] args);


        /// <summary>
        /// Writes the diagnostic message at the <c>Error</c> level using the specified parameters and formatting them with the supplied format provider.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A <see langword="string" /> containing format items.</param>
        /// <param name="args">Arguments to format.</param>
        [StringFormatMethod("message")]
        void Error(IFormatProvider formatProvider, [Localizable(false)] string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0, params object[] args);

        /// <summary>
        /// Writes the diagnostic message at the <c>Error</c> level.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <param name="message">Log message.</param>
        void Error([Localizable(false)] string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Error</c> level using the specified parameters.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <param name="message">A <see langword="string" /> containing format items.</param>
        /// <param name="args">Arguments to format.</param>
        [StringFormatMethod("message")]
        void Error([Localizable(false)] string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0, params object[] args);


        /// <summary>
        /// Writes the diagnostic message at the <c>Error</c> level using the specified parameter and formatting it with the supplied format provider.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="TArgument">The type of the argument.</typeparam>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A <see langword="string" /> containing one format item.</param>
        /// <param name="argument">The argument to format.</param>
        [StringFormatMethod("message")]
        void Error<TArgument>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument argument, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Error</c> level using the specified parameter.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="TArgument">The type of the argument.</typeparam>
        /// <param name="message">A <see langword="string" /> containing one format item.</param>
        /// <param name="argument">The argument to format.</param>
        [StringFormatMethod("message")]
        void Error<TArgument>([Localizable(false)] string message, TArgument argument, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Error</c> level using the specified arguments formatting it with the supplied format provider.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A <see langword="string" /> containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        [StringFormatMethod("message")]
        void Error<TArgument1, TArgument2>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Error</c> level using the specified parameters.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <param name="message">A <see langword="string" /> containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        [StringFormatMethod("message")]
        void Error<TArgument1, TArgument2>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Error</c> level using the specified arguments formatting it with the supplied format provider.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <typeparam name="TArgument3">The type of the third argument.</typeparam>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A <see langword="string" /> containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        /// <param name="argument3">The third argument to format.</param>
        [StringFormatMethod("message")]
        void Error<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Error</c> level using the specified parameters.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <typeparam name="TArgument3">The type of the third argument.</typeparam>
        /// <param name="message">A <see langword="string" /> containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        /// <param name="argument3">The third argument to format.</param>
        [StringFormatMethod("message")]
        void Error<TArgument1, TArgument2, TArgument3>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        #endregion

        #region Fatal() overloads 

        /// <overloads>
        /// Writes the diagnostic message at the <c>Fatal</c> level using the specified format provider and format parameters.
        /// </overloads>
        /// <summary>
        /// Writes the diagnostic message at the <c>Fatal</c> level.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="T">Type of the value.</typeparam>
        /// <param name="value">The value to be written.</param>
        void Fatal<T>(T value, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Fatal</c> level.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="T">Type of the value.</typeparam>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="value">The value to be written.</param>
        void Fatal<T>(IFormatProvider formatProvider, T value, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Fatal</c> level.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <param name="messageFunc">A function returning message to be written. Function is not evaluated if logging is not enabled.</param>
        void Fatal(LogMessageGenerator messageFunc, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);


        /// <summary>
        /// Writes the diagnostic message and exception at the <c>Fatal</c> level.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <param name="message">A <see langword="string" /> to be written.</param>
        /// <param name="exception">An exception to be logged.</param>
        /// <param name="args">Arguments to format.</param>
        [StringFormatMethod("message")]
        void Fatal(Exception exception, [Localizable(false)] string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0, params object[] args);

        /// <summary>
        /// Writes the diagnostic message and exception at the <c>Fatal</c> level.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A <see langword="string" /> to be written.</param>
        /// <param name="exception">An exception to be logged.</param>
        /// <param name="args">Arguments to format.</param>
        [StringFormatMethod("message")]
        void Fatal(Exception exception, IFormatProvider formatProvider, [Localizable(false)] string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0, params object[] args);

        /// <summary>
        /// Writes the diagnostic message at the <c>Fatal</c> level using the specified parameters and formatting them with the supplied format provider.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A <see langword="string" /> containing format items.</param>
        /// <param name="args">Arguments to format.</param>
        [StringFormatMethod("message")]
        void Fatal(IFormatProvider formatProvider, [Localizable(false)] string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0, params object[] args);

        /// <summary>
        /// Writes the diagnostic message at the <c>Fatal</c> level.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <param name="message">Log message.</param>
        void Fatal([Localizable(false)] string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Fatal</c> level using the specified parameters.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <param name="message">A <see langword="string" /> containing format items.</param>
        /// <param name="args">Arguments to format.</param>
        [StringFormatMethod("message")]
        void Fatal([Localizable(false)] string message, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0, params object[] args);


        /// <summary>
        /// Writes the diagnostic message at the <c>Fatal</c> level using the specified parameter and formatting it with the supplied format provider.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="TArgument">The type of the argument.</typeparam>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A <see langword="string" /> containing one format item.</param>
        /// <param name="argument">The argument to format.</param>
        [StringFormatMethod("message")]
        void Fatal<TArgument>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument argument, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Fatal</c> level using the specified parameter.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="TArgument">The type of the argument.</typeparam>
        /// <param name="message">A <see langword="string" /> containing one format item.</param>
        /// <param name="argument">The argument to format.</param>
        [StringFormatMethod("message")]
        void Fatal<TArgument>([Localizable(false)] string message, TArgument argument, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Fatal</c> level using the specified arguments formatting it with the supplied format provider.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A <see langword="string" /> containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        [StringFormatMethod("message")]
        void Fatal<TArgument1, TArgument2>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Fatal</c> level using the specified parameters.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <param name="message">A <see langword="string" /> containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        [StringFormatMethod("message")]
        void Fatal<TArgument1, TArgument2>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Fatal</c> level using the specified arguments formatting it with the supplied format provider.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <typeparam name="TArgument3">The type of the third argument.</typeparam>
        /// <param name="formatProvider">An IFormatProvider that supplies culture-specific formatting information.</param>
        /// <param name="message">A <see langword="string" /> containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        /// <param name="argument3">The third argument to format.</param>
        [StringFormatMethod("message")]
        void Fatal<TArgument1, TArgument2, TArgument3>(IFormatProvider formatProvider, [Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        /// <summary>
        /// Writes the diagnostic message at the <c>Fatal</c> level using the specified parameters.
        /// </summary><param name="memberName"></param><param name="sourceFilePath"></param><param name="sourceLineNumber"></param>
        /// <typeparam name="TArgument1">The type of the first argument.</typeparam>
        /// <typeparam name="TArgument2">The type of the second argument.</typeparam>
        /// <typeparam name="TArgument3">The type of the third argument.</typeparam>
        /// <param name="message">A <see langword="string" /> containing one format item.</param>
        /// <param name="argument1">The first argument to format.</param>
        /// <param name="argument2">The second argument to format.</param>
        /// <param name="argument3">The third argument to format.</param>
        [StringFormatMethod("message")]
        void Fatal<TArgument1, TArgument2, TArgument3>([Localizable(false)] string message, TArgument1 argument1, TArgument2 argument2, TArgument3 argument3, [CallerMemberName] string memberName = "", [CallerFilePath] string sourceFilePath = "", [CallerLineNumber] int sourceLineNumber = 0);

        #endregion
#endif
    }
}
