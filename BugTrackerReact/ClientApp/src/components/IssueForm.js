// TODO: get Index/Fetch Data component to render on redirect
// Learned: content-type json needed, db.Save() needed, [FromBody]--else empty values posted--and restarting server even though "watch" is running

import React, { Component } from 'react';
import { Button, Form, FormGroup, Label, Input, FormText } from 'reactstrap';

async function postIssue(values) {
  const response = await fetch("api/Issues/Create", {
    method: "POST",
    body: JSON.stringify(values.Description),
    headers: {
      "content-type": "application/json"
    },
  });
  return await response.json();
}
export class IssueForm extends Component {

  constructor(props) {
    super(props);

    this.state = {
      // issueName: "Issue",
      Description: "More detailed description",
      // issueTags: []
    }
  }

  handleInputChange = (e) => {
    const name = e.target.name;
    const value = e.target.value;
    this.setState({
      [name]: value
    })
  }

  handleSubmit = (e) => {
    e.preventDefault();
    postIssue(this.state);
    this.setState({
      // issueName: "Issue",
      Description: "More detailed description"
    })
  }

  clearValues = (e) => {
    const name = e.target.name;
    this.setState({
      [name]: ""
    })
  }

  render() {
    return (
      <Form onSubmit={this.handleSubmit}>
        <FormGroup>
          <Input className="text-primary" type="text" name="issueName" value={this.state.issueName} required
            onChange={this.handleInputChange}
            onFocus={this.clearValues} />
        </FormGroup>
        <FormGroup>
          <Input className="text-success" type="textarea" id="Description" name="Description"
            value={this.state.Description}
            onChange={this.handleInputChange}
            onFocus={this.clearValues} />
        </FormGroup>
        <Button color="info" type="submit">Save Issue</Button>
      </Form>
    )
  }
}