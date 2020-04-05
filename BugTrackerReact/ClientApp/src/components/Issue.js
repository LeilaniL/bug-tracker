import React from 'react';

const styles = {
  border: '1px solid yellow',
  padding: '2em'
}

const Issue = (props) => {
  return (
    <div style={styles}>
      <h3>{props.description}</h3>
      <p>{props.issueId}</p>
    </div>
  );
}

export default Issue;