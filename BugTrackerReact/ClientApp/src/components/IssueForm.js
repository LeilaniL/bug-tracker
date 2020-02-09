import React, { Component } from 'react';
import { Button, Form, FormGroup, Label, Input, FormText } from 'reactstrap';

export class IssueForm extends Component {

  constructor(props) {
    super(props);

    this.state = {
      issueName: "Issue",
      issueDescription: "More detailed description",
      issueTags: []
    }
  }

  handleInputChange = (e) => {
    // e.preventDefault();
    // this.setState({
    //   issueName: "Submitted!",
    //   issueDescription: "Submitted description"
    // });
    const name = e.target.name;
    const value = e.target.value;
    this.setState({
      [name]: value
    })
  }

  handleSubmit = (e) => {
    e.preventDefault();
    console.log("Submitted!");
    this.setState({
      issueName: "Issue",
      issueDescription: "More detailed description"
    })
  }

  clearValues = (e) => {
    const name = e.target.name;
    const value = e.target.value;
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
          <Input className="text-success" type="textarea" id="issueDescription" name="issueDescription"
            value={this.state.issueDescription}
            onChange={this.handleInputChange}
            onFocus={this.clearValues} />
        </FormGroup>
        <Button color="info" type="submit">Save Issue</Button>
      </Form>
    )
  }

}