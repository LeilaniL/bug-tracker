import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { FetchData } from './components/FetchData';
import { IssueForm } from './components/IssueForm';

export default class App extends Component {
  static displayName = App.name;

  render() {
    return (
      <Layout>
        <Route exact path='/' component={IssueForm} />
        <Route path='/fetch-data' component={FetchData} />
        <Route path='/issues/create' component={IssueForm} />

      </Layout>
    );
  }
}
