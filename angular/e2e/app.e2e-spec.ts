import { CallOfShareTemplatePage } from './app.po';

describe('CallOfShare App', function() {
  let page: CallOfShareTemplatePage;

  beforeEach(() => {
    page = new CallOfShareTemplatePage();
  });

  it('should display message saying app works', () => {
    page.navigateTo();
    expect(page.getParagraphText()).toEqual('app works!');
  });
});
