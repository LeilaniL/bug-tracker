// TODO: get Index/Fetch Data component to render on redirect
// Learned: content-type json needed, db.Save() needed, [FromBody]--else empty values posted--and restarting server even though "watch" is running

import React, { Component } from 'react';
import { Button, Form, FormGroup, Label, Input, FormText } from 'reactstrap';
import { Redirect } from 'react-router-dom';
import testPic from '../img/text-input-caret.png';

async function postIssue(values) {
  const response = await fetch("api/Issues/Create", {
    method: "POST",
    body: JSON.stringify(values),
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
      Redirect: false,
      RightSteps: "",
      CursorDisplay: true
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
      Description: "",
      RightSteps: "",
      Redirect: true
    })
  }

  clearValues = (e) => {
    const name = e.target.name;
    this.setState({
      [name]: ""
    })
  }

  render() {
    return this.state.Redirect ? <Redirect to="/fetch-data" /> : (
      <Form onFocus={() => !this.state.CursorDisplay} onSubmit={this.handleSubmit} style={{ margin: "auto", width: "33%" }}>
        {/* <FormGroup>
          <Input className="text-primary" style={{ backgroundColor: "transparent", outline: "none", border: "none" }} type="text" name="issueName" value={this.state.issueName} required
            onChange={this.handleInputChange}
            onFocus={this.clearValues} />
        </FormGroup> */}
        <FormGroup>
          {this.state.CursorDisplay ? <img src={testPic} alt="test" style={{ width: "1em" }} /> : <Input style={{ color: "dark-gray", backgroundColor: "transparent", outline: "none", border: "none" }} type="textarea" id="Description" name="Description"
            value={this.state.Description}
            onChange={this.handleInputChange}
            onFocus={this.clearValues} >
          </Input>}
        </FormGroup>
        {/* <FormGroup>
          <Input className="text-info" style={{ backgroundColor: "#3b3939" }} type="textarea" id="RightSteps" name="RightSteps"
            value={this.state.RightSteps}
            onChange={this.handleInputChange}
            onFocus={this.clearValues} />
        </FormGroup> */}
        <Button color="info" type="submit" style={{ float: "right" }}>Save Issue</Button>
      </Form >
    )
  }
}
