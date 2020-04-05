import React, { Component } from 'react';
import Issue from './Issue';

const textStyles = {
  color: 'aqua'
}
export class FetchData extends Component {
  static displayName = FetchData.name;

  constructor(props) {
    super(props);
    this.state = { issues: [], loading: true };

    fetch('api/Issues/IssueIndex')
      .then(response => response.json())
      .then(data => {
        this.setState({ issues: data, loading: false });
      });
  }

  static renderissuesTable(issues) {
    return (
      // <table className='table table-striped' style={textStyles}>
      //   <Issue />
      //   <thead>
      //     <tr>
      //       <th>Issue ID</th>
      //       <th>Description</th>
      //     </tr>
      //   </thead>
      //   <tbody>
      //     {issues.map(issue =>
      //       <tr key={issue.issueId}>
      //         <td>{issue.issueId}</td>
      //         <td>{issue.description}</td>
      //       </tr>
      //     )}
      //   </tbody>
      // </table >
      <div>
        {issues.map(issue =>
          <Issue description={issue.description} issueId={issue.issueId}
            key={issue.issueId} />
        )}
      </div>
    );
  }

  render() {
    let contents = this.state.loading
      ? <p><em>Loading...</em></p>
      : FetchData.renderissuesTable(this.state.issues);

    return (
      <div>
        <h1>Bugs Journal</h1>
        <p>This component demonstrates fetching data from the server.</p>
        {contents}
      </div>
    );
  }
}
