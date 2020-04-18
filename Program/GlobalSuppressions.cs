/* <copyright file="GlobalSuppressions.cs" company="PlaceholderCompany">
 * Copyright (c) PlaceholderCompany. All rights reserved.
 * </copyright>
 */

/* This file is used by Code Analysis to maintain SuppressMessage
 * attributes that are applied to this project.
 * Project-level suppressions either have no target or are given
 * a specific target and scoped to a namespace, type, member, etc.
 */

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Reliability", "CA2000:Dispose objects before losing scope", Justification = "<Does not need to be corrected>", Scope = "member", Target = "~M:Program.Program.Main")]
[assembly: SuppressMessage("Globalization", "CA1305:Specify IFormatProvider", Justification = "<Does not need to be corrected>", Scope = "member", Target = "~M:Program.Form1.CelInput_ValueChanged(System.Object,System.EventArgs)")]
[assembly: SuppressMessage("Globalization", "CA1305:Specify IFormatProvider", Justification = "<Does not need to be corrected>", Scope = "member", Target = "~M:Program.Form1.FahInput_ValueChanged(System.Object,System.EventArgs)")]
[assembly: SuppressMessage("Globalization", "CA1305:Specify IFormatProvider", Justification = "<Does not need to be corrected>", Scope = "member", Target = "~M:Program.Form1.KelInput_ValueChanged(System.Object,System.EventArgs)")]
