﻿namespace OpenProtocolInterpreter.Job.Advanced
{
    /// <summary>
    /// Job line control alert 1
    /// <para>
    ///     This message tells the integrator that, for example, 
    ///     a car has reached 80% of the station and that the
    ///     Job line control alert 1 is set in the controller.
    /// </para>
    /// <para>
    ///     Only available when a job has been selected.
    /// </para>
    /// <para>Message sent by: Controller</para>
    /// <para>Answer: <see cref="Mid0125"/> Job line control info acknowledged</para>
    /// </summary>
    public class Mid0122 : Mid, IAdvancedJob, IController
    {
        private const int LAST_REVISION = 1;
        public const int MID = 122;

        public Mid0122() : this(0)
        {

        }

        public Mid0122(int? noAckFlag = 0) : base(MID, LAST_REVISION, noAckFlag) { }
    }
}
