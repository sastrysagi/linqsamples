// ***********************************************************************
// Assembly         : LINQSamples
// Author           : V U M Sastry Sagi
// Created          : 07-10-2023
// ***********************************************************************
// <copyright file="ObjectDumper.cs" company="LINQSamples">
//     Copyright (c) KFin Technologies Ltd. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Collections;
using System.Reflection;
using System.Text;

namespace LINQSamples.Helper;

/// <summary>
/// Class ObjectDumper.
/// </summary>
public class ObjectDumper
{
    /// <summary>
    /// The builder
    /// </summary>
    private StringBuilder builder;
    /// <summary>
    /// The level
    /// </summary>
    private int level;
    /// <summary>
    /// The depth
    /// </summary>
    private int depth;

    /// <summary>
    /// Dumps the specified o.
    /// </summary>
    /// <param name="o">The o.</param>
    /// <param name="depth">The depth.</param>
    /// <returns>System.String.</returns>
    public static string Dump(object o, int depth = 255)
    {
        var dumper = new ObjectDumper(depth);
        dumper.WriteObject(null, o);
        return dumper.builder.ToString();
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ObjectDumper"/> class.
    /// </summary>
    /// <param name="depth">The depth.</param>
    private ObjectDumper(int depth)
    {
        this.builder = new StringBuilder();
        this.depth = depth;
    }

    /// <summary>
    /// Writes the specified s.
    /// </summary>
    /// <param name="s">The s.</param>
    private void Write(string s)
    {
        if (s != null)
        {
            builder.Append(s.PadRight(level * 2));
        }
    }

    /// <summary>
    /// Writes the line.
    /// </summary>
    private void WriteLine()
    {
        builder.AppendLine();
    }

    /// <summary>
    /// Writes the object.
    /// </summary>
    /// <param name="prefix">The prefix.</param>
    /// <param name="o">The o.</param>
    private void WriteObject(string prefix, object o)
    {
        Write(prefix);
        if (o == null || o is ValueType || o is string)
        {
            WriteValue(o);
            WriteLine();
        }
        else if (o is IEnumerable enumerable)
        {
            WriteLine();
            if (level < depth)
            {
                level++;
                foreach (var element in enumerable)
                {
                    WriteObject("  ", element);
                }
                level--;
            }
        }
        else
        {
            WriteObjectProperties(o);
            WriteLine();
        }
    }

    /// <summary>
    /// Writes the value with prefix.
    /// </summary>
    /// <param name="prefix">The prefix.</param>
    /// <param name="value">The value.</param>
    private void WriteValueWithPrefix(string prefix, object value)
    {
        Write($"  {prefix} = ");
        WriteValue(value);
        WriteLine();
    }

    /// <summary>
    /// Writes the value.
    /// </summary>
    /// <param name="o">The o.</param>
    private void WriteValue(object o)
    {
        if (o == null)
        {
            Write("null");
        }
        else if (o is DateTime dateTime)
        {
            Write(dateTime.ToShortDateString());
        }
        else if (o is ValueType || o is string)
        {
            Write(o.ToString());
        }
        else if (o is IEnumerable enumerable)
        {
            Write("[");
            Write(Environment.NewLine);
            level++;
            foreach (var item in enumerable)
            {
                WriteObjectProperties(item);
                Write(Environment.NewLine);
            }
            level--;
            Write("]");
        }
        else
        {
            Write("{");
            Write(Environment.NewLine);
            level++;
            WriteObjectProperties(o);
            level--;
            Write("}");
        }
    }

    /// <summary>
    /// Writes the object properties.
    /// </summary>
    /// <param name="o">The o.</param>
    private void WriteObjectProperties(object o)
    {
        if (o == null)
        {
            return;
        }

        var members = o.GetType().GetMembers(BindingFlags.Public | BindingFlags.Instance);
        foreach (MemberInfo member in members)
        {
            if (member is FieldInfo field)
            {
                WriteValueWithPrefix(field.Name, field.GetValue(o));
            }
            else if (member is PropertyInfo property)
            {
                WriteValueWithPrefix(property.Name, property.GetValue(o));
            }
        }
    }
}

