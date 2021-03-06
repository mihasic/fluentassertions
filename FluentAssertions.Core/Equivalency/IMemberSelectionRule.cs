using System.Collections.Generic;

namespace FluentAssertions.Equivalency
{
    /// <summary>
    /// Represents a rule that defines which members of the subject-under-test to include while comparing
    /// two objects for structural equality.
    /// </summary>
    public interface IMemberSelectionRule
    {
        /// <summary>
        /// Adds or removes properties to/from the collection of subject members that must be included while
        /// comparing two objects for structural equality.
        /// </summary>
        /// <param name="selectedMembers">
        ///     A collection of members that was prepopulated by other selection rules. Can be empty.</param>
        /// <param name="context"></param>
        /// <param name="config"></param>
        /// <param name="info">
        /// Type info about the subject.
        /// </param>
        /// <returns>
        /// The collection of members after applying this rule. Can contain less or more than was passed in.
        /// </returns>
        IEnumerable<SelectedMemberInfo> SelectMembers(IEnumerable<SelectedMemberInfo> selectedMembers, ISubjectInfo context, IEquivalencyAssertionOptions config);
    }
}